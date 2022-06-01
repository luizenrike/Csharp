using System;

class Program
{
    static void Main(string[] Args)
    {
        Console.Write("Informe um número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe um segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        operations op = new operations();
        

        Console.WriteLine("A soma é: " + op.soma(n1, n2));
        Console.WriteLine("A subtração é: " + op.subtracao(n1, n2));
        Console.WriteLine("A multiplicãção é: " + op.multiplicacao(n1, n2));
        Console.WriteLine("A divisão é: " + op.divisao(n1, n2));

    }
}

class operations
{
    public int soma(int a, int b)
    {
        return a + b;
    }

    public int subtracao(int a, int b)
    {
        return a - b; 
    }

    public int multiplicacao(int a, int b)
    {
        return a * b;
    }

    public int divisao(int a, int b)
    {
        return a / b;
    }
}