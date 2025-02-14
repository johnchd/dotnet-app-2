WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/greeting", () => "aws w/ .NET 9 ---test1");


//defines POST
app.MapPost("/message", async (HttpRequest request) =>
{
    // reads JSON body from the HTTP request
    // then converts the JSON string into a C# string using ReadFromJsonAsync<string>() method
    string message = await request.ReadFromJsonAsync<string>();
    return $"Received: {message}";
});

//defines PUT
app.MapPut("/message", async (HttpRequest request) =>
{
    string message = await request.ReadFromJsonAsync<string>();
    return $"Updated to: {message}";
});

// test

app.Run("http://*:80");
