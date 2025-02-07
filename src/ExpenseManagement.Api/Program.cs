using ExpenseManagement.Api.Configurations;
using Serilog;
using Serilog.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Configure logger
// TODO: configure logger from AppSettings.json & move to extension methods
var logger = Log.Logger = new LoggerConfiguration()
.Enrich.FromLogContext()
.CreateLogger();

var appLogger = new SerilogLoggerFactory(logger)
    .CreateLogger<Program>();

builder.Services.AddServiceConfigurations(builder, appLogger);

var app = builder.Build();

app.Configure();

app.Run();

// TODO: update editors config : 1. Var only if type is explicit, 2. error when no method summary in every project
