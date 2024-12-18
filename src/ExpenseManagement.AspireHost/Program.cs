var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ExpenseManagement_Web>("web");
builder.AddProject<Projects.ExpenseManagement_Api>("api");

builder.Build().Run();
