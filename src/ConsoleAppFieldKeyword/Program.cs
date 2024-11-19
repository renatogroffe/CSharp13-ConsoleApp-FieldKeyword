using ConsoleAppFieldKeyword.Models;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 9 + C# 13 | Field Keyword (Preview) *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

double[] temperaturasFahrenheit = [ 32, 80.5, - 600, 212, -100.7 ];
foreach (var valorFahrenheit in temperaturasFahrenheit)
{
    try
    {
        var temperatura = new Temperatura()
        {
            Fahrenheit = valorFahrenheit
        };
        Console.WriteLine($"Temperatura em Fahrenheit: {temperatura.Fahrenheit} | " +
            $"Temperatura em Celsius: {temperatura.Celsius:0.00}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao converter a temperatura {valorFahrenheit}: " +
            $"{ex.Message} | {ex.GetType().Name}");
    }
    Console.WriteLine();
}