// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World bitwise!");

bool sair = false;

try
{
    while (!sair)
    {
        int a = 0; int b = 0; int c = 0;
        Console.WriteLine("Informe o primeiro bitwise:");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo bitwise:");
        b = int.Parse(Console.ReadLine());

        c = a & b;
        if(c == 0)
            Console.WriteLine($"{b} não contem {a}: {a & b}");
        else
            Console.WriteLine($"{b} contem {a}: {a & b}");

        System.Console.WriteLine("acabou ------- digite 0 (zero) para sair...");
        if (int.Parse(Console.ReadLine()) == 0) sair = true;
    }
}
catch (Exception)
{

}



