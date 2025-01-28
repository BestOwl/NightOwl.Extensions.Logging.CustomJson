# NightOwl.Extensions.Logging.CustomJson

A customizable JSON formatter for .NET logging (Microsoft.Extensions.Logging) that allows you to control the structure and naming of your JSON log output.

## Features

- Same as `JsonConsoleFormatter` but with customizable field names
- Customizable field names for all log properties
- Custom log level name mapping

## Installation
```bash
dotnet add package NightOwl.Extensions.Logging.CustomJson
```

## Usage

### Basic Setup
```csharp
builder.Logging.AddConsoleFormatter<CustomJsonConsoleFormatter, CustomJsonConsoleFormatterOptions>();
builder.Services.AddLogging(builder =>
{
    builder.AddJsonConsole(options =>
    {
        options.FormatterName = "CustomJson";
        options.TimestampFormat = "yyyy-MM-dd HH:mm:ss.fff";
        options.UseUtcTimestamp = true;
    });
});
``` 

### Customizing Field Names

You can customize the names of fields in the JSON output:
```csharp
builder.Logging.AddConsoleFormatter<CustomJsonConsoleFormatter, CustomJsonConsoleFormatterOptions>();
builder.Services.AddLogging(builder =>
{
    builder.AddJsonConsole(options =>
    {
        options.FormatterName = "CustomJson";
        options.TimestampFieldName = "time";
        options.LogLevelFieldName = "severity";
        options.MessageFieldName = "msg";
        options.CategoryFieldName = "logger";
        options.EventIdFieldName = "eventId";
        options.ExceptionFieldName = "error";
    });
});
```

### Custom Log Level Names

You can map log levels to custom names:
```csharp
builder.Logging.AddConsoleFormatter<CustomJsonConsoleFormatter, CustomJsonConsoleFormatterOptions>();
builder.Services.AddLogging(builder =>
{
    builder.AddJsonConsole(options =>
    {
        options.FormatterName = "CustomJson";
        options.LogLevelNameMapping = new Dictionary<LogLevel, string>
        {
            [LogLevel.Error] = "err",
            [LogLevel.Warning] = "warn",
            [LogLevel.Information] = "info",
            [LogLevel.Debug] = "dbug",
            [LogLevel.Trace] = "trc",
            [LogLevel.Critical] = "crit"
        };
    });
});
```

### Configuration

You can also configure the formatter using `appsettings.json`:

Add the formatter to the logging configuration:
```csharp
builder.Logging.AddConsoleFormatter<CustomJsonConsoleFormatter>();
```

Configure the formatter options in `appsettings.json`:
```json
{
    "Logging": {
        "Console": {
            "FormatterName": "CustomJson",
            "FormatterOptions": {
                "LogLevelFieldName": "severity",
                "MessageFieldName": "msg",
                "CategoryFieldName": "logger",
                "EventIdFieldName": "eventId",
                "ExceptionFieldName": "error"
            }
        }
    }
}
```

## License

This project is licensed under the MIT License - see the LICENSE file for details.