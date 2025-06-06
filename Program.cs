using System;

class Program
{
    static void Main()
    {
        
        Console.Clear();

        Console.WriteLine("             --- Etanol ou Gasolina? ---\n");

        Console.WriteLine(@"Eae usuario desconhecido, está com problema de escolher entre alcool ou gasosa?
        Este programa ira te ajudar a decidir qual dos dois vale mais apena gastar hahaha");


        decimal precoEtanol = LerPreco("Digite o preço do etanol (R$).....: ");
        decimal precoGasolina = LerPreco("Digite o preço da gasolina (R$)...: ");


        decimal razao = CalcularRazao(precoEtanol, precoGasolina);
        bool valeGasolina = ValePenaGasolina(razao);


        ExibirResultados(razao, valeGasolina);
    }


    static decimal LerPreco(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToDecimal(Console.ReadLine());
    }


    static decimal CalcularRazao(decimal etanol, decimal gasolina)
    {
        return (etanol / gasolina) * 100;
    }


    static bool ValePenaGasolina(decimal razao)
    {
        return razao > 73;
    }


    static void ExibirResultados(decimal razao, bool valeGasolina)
    {
        Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina.");
        Console.WriteLine($"\nRecomendação: Abasteça com {(valeGasolina ? "GASOLINA" : "ETANOL")}.");
    }
}