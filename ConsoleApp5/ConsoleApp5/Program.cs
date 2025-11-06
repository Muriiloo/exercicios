using System.Globalization;

namespace ConsoleApp5;

class Program
{
    static void Main()
    {
        var dataAtual = DateTime.Now;
        string diaEmTexto = dataAtual.ToString("F", new CultureInfo("pt-BR"));
        Console.WriteLine(diaEmTexto);

        var dataAtual2 = DateTime.Now;
        string diaEmTexto2 = dataAtual2.ToString("d", new CultureInfo("pt-BR"));
        Console.WriteLine(diaEmTexto2);

        var horaAtual = DateTime.Now;
        string horaEmTexto = horaAtual.ToString("T", new CultureInfo("pt-BR"));
        Console.WriteLine(horaEmTexto);

        var dataAtual3 = DateTime.Now;
        string diaEmTexto3 = dataAtual3.ToString("D", new CultureInfo("pt-BR"));
        Console.WriteLine(diaEmTexto3);

    }
}
