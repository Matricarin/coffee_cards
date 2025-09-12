# dev notes

## 🔹 Настройка EF Core

Configuration — IEntityTypeConfiguration — метод Configure
Используй отдельные классы конфигурации для сущностей (чистота кода, гибкость).

Интерфейс DbContext — DbSets — метод SaveChanges
Определи интерфейс IApplicationDbContext, чтобы можно было легко подменять DbContext в тестах.

Реализация DbContext
Наследуй от DbContext и реализуй интерфейс.

DbInitializer
Сервис для инициализации БД (создание схемы, сидирование тестовых данных).

## 🔹 Настройка EF Core

Configuration — IEntityTypeConfiguration — метод Configure
Используй отдельные классы конфигурации для сущностей (чистота кода, гибкость).

Интерфейс DbContext — DbSets — метод SaveChanges
Определи интерфейс IApplicationDbContext, чтобы можно было легко подменять DbContext в тестах.

Реализация DbContext
Наследуй от DbContext и реализуй интерфейс.

DbInitializer
Сервис для инициализации БД (создание схемы, сидирование тестовых данных).

## 🔹 Маппинг

Request / Response DTOs
Никогда не отдавай доменные модели напрямую, используй DTO.

AutoMapper
Подключи AutoMapper для автоматического преобразования DTO ↔ сущности.

Generic IMapWith
Интерфейс-маркер, который упрощает настройку маппинга.

AssemblyMappingProfile
Единый профиль AutoMapper, который собирает все маппинги в проекте.

## 🔹 MediatR и CQRS

CQRS + MediatR
Делим логику:

Команды (Commands) — для изменения данных.

Запросы (Queries) — для получения данных.

MediatR для управления сервисами
Контроллеры не вызывают напрямую сервисы, а через MediatR → меньше зависимостей.

Создание команд

Модель команды (IRequest).

Обработчик (IRequestHandler).

Хендлер команды + работа с БД
В обработчике инжектим DbContext, изменяем данные.

Для запросов нужны ViewModels

Для вывода одного объекта → ViewModel.

Для списка объектов → DTO.

Создание запросов и обработчиков
Аналогично командам, но они только читают данные.

## 🔹 Dependency Injection (DI)

Где брать зависимости

Через конструктор (основной способ).

Через Startup.ConfigureServices (регистрация зависимостей).

Через HttpContext.RequestServices (редко).

Через ApplicationServices (для инфраструктуры).

Как регистрировать зависимости

Создавай extension-методы (AddApplication(), AddInfrastructure()), чтобы хранить регистрацию сервисов отдельно.

Регистрируй DbContext.

Регистрируй интерфейс IApplicationDbContext для тестов.

Добавляй MediatR как зависимость.

## 🔹 Контроллеры

DI для контроллеров
Контроллеры получают зависимости через конструктор (обычно IMediator).

Строка подключения к БД
Хранится в appsettings.json.

Настройка AutoMapper
Подключи профиль в Startup.

CORS (Cross-Origin Resource Sharing)
Разрешает запросы к API с других доменов.
➡ Нужно, если фронтенд и бэкенд на разных доменах.

Same-Origin Policy
Браузер блокирует запросы между разными источниками (домен, порт, протокол) — защита по умолчанию.

CSRF (Cross-Site Request Forgery)
Атаки через поддельные запросы от имени пользователя.
➡ Для API обычно решается с помощью JWT + SameSite cookies.

Базовый контроллер
Можно создать BaseController, где хранить IMediator, UserId, общие методы.

Методы контроллеров через Mediator
Контроллеры становятся тонкими: принимают запрос → вызывают команду/запрос через Mediator → возвращают ответ.

DTO в Core и API слоях

В Core: DTO/ViewModels для бизнес-логики.

В API: Request/Response DTO для входа/выхода.

Между ними маппинг через AutoMapper.

🔹 Валидация

FluentValidation

Популярная библиотека для декларативной валидации.

Позволяет писать валидаторы в виде правил:

```csharp
RuleFor(x => x.Email).NotEmpty().EmailAddress();
RuleFor(x => x.Password).MinimumLength(6);
```

Валидаторы должны быть рядом с командами и их хендлерами

Например:

RegisterUserCommand

RegisterUserCommandValidator

RegisterUserCommandHandler

Это поддерживает порядок и понятную структуру.

Validation Behavior — IPipelineBehavior

В MediatR есть конвейер (pipeline).

Можно добавить middleware, который автоматически валидирует команду перед выполнением хендлера.

Пример:

```csharp
public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var context = new ValidationContext<TRequest>(request);
        var failures = _validators
            .Select(v => v.Validate(context))
            .SelectMany(result => result.Errors)
            .Where(f => f != null)
            .ToList();

        if (failures.Any())
            throw new ValidationException(failures);

        return await next();
    }
}

```
Регистрация Behavior в DI
Добавляется как сервис в контейнер:
```csharp
services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

```

🔹 Middleware

Порядок добавления middleware
В ASP.NET Core middleware выполняются в том порядке, в котором они добавлены.
Обычно так:

Логирование (Serilog).

Обработка ошибок.

Статические файлы.

Аутентификация → Авторизация.

Endpoint routing.

Custom Exception Handler Middleware

Перехватывает исключения и возвращает JSON-ответ в нужном формате.

Например:

```csharp
public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var response = new { message = ex.Message };
            await context.Response.WriteAsJsonAsync(response);
        }
    }
}

```

Добавление middleware через extension method
Обычно создаётся расширение:

```csharp
public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionHandlingMiddleware>();
    }
}
```

## ...