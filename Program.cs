var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

app.MapGet("/add", (int num1, int num2) => AddNumbers(num1, num2));

app.MapGet("/subtract", (int num1, int num2) => SubtractNumbers(num1, num2));

app.MapGet("/multiply", (int num1, int num2) => MultiplyNumbers(num1, num2));

app.MapGet("/divide", (int num1, int num2) => DivideNumbers(num1, num2));

app.Run();

string AddNumbers(int num1, int num2)
{
    return $"Summan av {num1} och {num2} är: {num1 + num2}";
}

string SubtractNumbers(int num1, int num2)
{
    return $"Differensen av {num1} och {num2} är: {num1 - num2}";
}

string MultiplyNumbers(int num1, int num2)
{
    return $"Produkten av {num1} och {num2} är: {num1 * num2}";
}

string DivideNumbers(int num1, int num2)
{
    return $"Kvoten av {num1} och {num2} är: {num1 / (double)num2}";
}
