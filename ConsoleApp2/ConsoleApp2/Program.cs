namespace ConsoleApp2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro nome: ");
        var primeiroNome = Console.ReadLine();

        Console.WriteLine("Digite o sobrenome: ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine($"Nome completo: {primeiroNome} {sobrenome}");
    }
}