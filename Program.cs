double notaUm, notaDois, notaTres, notaQuatro, media;
string resultado;

Console.Clear();
Console.WriteLine("--- Média ---\n");
Console.WriteLine("Digite suas notas abaixo:");

Console.WriteLine("Nota 1:");
notaUm = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nota 2:");
notaDois = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nota 3:");
notaTres = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nota 4:"); 
notaQuatro = Convert.ToDouble(Console.ReadLine());


if(notaUm < 0 || notaUm > 10 || notaDois < 0 || notaDois > 10 || notaTres < 0 || notaTres > 10 || notaQuatro < 0 || notaQuatro > 10)
{
    Console.WriteLine("Digite apenas números entre 0 e 10!"); 
}
else{
    media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

    if (media < 5)
    { 
        resultado = "Reprovado";
    }

else if (media > 6)
    { 
    resultado = "Aprovado";
    }

else { 
    resultado = "Em recuperação";
     }
Console.WriteLine($"Você ficou com a média {media:N1}. Resultado: {resultado}"); 
     
}
