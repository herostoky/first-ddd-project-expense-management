var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ExpenseManagement_Web>("web");

builder.Build().Run();
