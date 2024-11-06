var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginGTO) => {
    if(loginGTO.Email == "adm@teste.com" && loginGTO.Senha == "123456")
        return Results.Ok("Login com sucesso.");
    else
        return Results.Unauthorized();
});

app.Run();

