using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace NightOwl.Extensions.Logging.CustomJson;

public class CustomJsonConsoleFormatterOptions : ConsoleFormatterOptions
{
    public JsonWriterOptions JsonWriterOptions { get; set; }

    /// <summary>
    /// Custom mapping for log level names in the output
    /// </summary>
    public Dictionary<LogLevel, string>? LogLevelNameMapping { get; set; }

    /// <summary>
    /// Custom field name for the timestamp (default: "Timestamp")
    /// </summary>
    public string? TimestampFieldName { get; set; }

    /// <summary>
    /// Custom field name for the event ID (default: "EventId")
    /// </summary>
    public string? EventIdFieldName { get; set; }

    /// <summary>
    /// Custom field name for the log level (default: "LogLevel")
    /// </summary>
    public string? LogLevelFieldName { get; set; }

    /// <summary>
    /// Custom field name for the category (default: "Category")
    /// </summary>
    public string? CategoryFieldName { get; set; }

    /// <summary>
    /// Custom field name for the message (default: "Message")
    /// </summary>
    public string? MessageFieldName { get; set; }

    /// <summary>
    /// Custom field name for the exception (default: "Exception")
    /// </summary>
    public string? ExceptionFieldName { get; set; }
}