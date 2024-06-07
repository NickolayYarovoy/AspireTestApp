var builder = DistributedApplication.CreateBuilder(args);

var dbPassword = builder.AddParameter("DatabasePassword");
var discordToken = builder.AddParameter("DiscordToken");

var dbServer = builder.AddPostgres("db", password: dbPassword)
    .WithDataVolume().WithPgAdmin();
var db = dbServer.AddDatabase("BankBase");

var api = builder.AddProject<Projects.WebAPI>("api")
    .WithReference(db);

var bot = builder.AddProject<Projects.AspireDiscordApp>("bot")
  .WithReference(api).WithEnvironment("token", discordToken);

builder.Build().Run();
