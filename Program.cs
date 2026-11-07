double n1, n2, n3, n4, media;
string resultado;

Console.WriteLine("---Média notas---");
Console.WriteLine("Digite as notas abaixo.");

Console.WriteLine("Nota 1: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 2: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 3: ");
n3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 4: ");
n4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (n1 < 0 || n1 > 10
|| n2 < 0 || n2 > 10 
|| n3 < 0 || n3 > 10
|| n4 < 0 || n4 > 10)

Console.WriteLine("Digite somente notas entre 0 e 10.");

else
{
    media = (n1 + n2 + n3 + n4) / 4;

    if(media < 5)
    {
        resultado = "reprovado";
    }
    else if (media > 6)
    {
        resultado = "aprovado";
    }
    else
    {
        resultado = "em recuperação";
    }

    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");
}

