using UnitConverter.Conversions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());



app.MapGet("/convert/length", (double value, string from, string to) =>
{
    double convertedValue = Length.Convert(value, from, to);
    return Results.Ok(new
    {
        result = convertedValue,
        from,
        to
    });
});

app.MapGet("/convert/weight", (double value, string from, string to) =>
{
    double convertedValue = Weight.Convert(value, from, to);
    return Results.Ok(new
    {
        result = convertedValue,
        from,
        to
    });

});

app.MapGet("/convert/temperature", (double value, string from, string to) =>
{
    double convertedValue = Temperature.Convert(value, from, to);
    return Results.Ok(new
    {
        result = convertedValue,
        from,
        to
    });
});


app.Run();

