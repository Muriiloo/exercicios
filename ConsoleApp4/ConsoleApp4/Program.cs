namespace ConsoleApp4;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra: ");
        var palavra = Console.ReadLine();

        if(palavra == null || palavra.Length == 0)
        {
            Console.WriteLine("Não foi nada digitado");
            return;
        }

        var quantidade = palavra.Length;
        Console.WriteLine(quantidade);
    }
}
