namespace ConsoleApp3;

class Program
{
    static void Main()
    {
        double valor1 = 5.5;
        double valor2 = 5.5;

        var soma = valor1 + valor2;
        Console.WriteLine($"Soma: {soma}");
        var subtracao = valor1 - valor2;
        Console.WriteLine($"Subtração: {subtracao}");
        var multiplicacao = valor1 * valor2;
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        if (valor2 == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida.");
        }
        else
        {
            var divisao = valor1 / valor2;
            Console.WriteLine($"Divisão: {divisao}");

        }
        var media = (valor1 + valor2) / 2;
        Console.WriteLine($"Média: {media}");
    }
}