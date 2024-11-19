namespace ConsoleAppFieldKeyword.Models;

public class Temperatura
{
    public double Fahrenheit
    {
        get;
        set
        {
            if (value < -459.67)
                throw new ArgumentOutOfRangeException(
                    $"Valor de temperatura em Fahrenheit invalido: {value}");
            field = value;
        }
    }

    public double Celsius
    {
        get => (Fahrenheit - 32) * 5 / 9;
    }
}