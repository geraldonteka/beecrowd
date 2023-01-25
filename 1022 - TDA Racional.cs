using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        int numerador;
        int denominador;
        int mdc;

        for (int i = 0; i < n; i++)
        {
            string[] expressaoMatematica = Console.ReadLine().Split(' ', ' ', ' ', ' ', ' ', ' ');
            int n1 = int.Parse(expressaoMatematica[0]);
            char barra = char.Parse(expressaoMatematica[1]);
            int d1 = int.Parse(expressaoMatematica[2]);
            char operador = char.Parse(expressaoMatematica[3]);
            int n2 = int.Parse(expressaoMatematica[4]);
            barra = char.Parse(expressaoMatematica[5]);
            int d2 = int.Parse(expressaoMatematica[6]);

            if (operador == '+')
            {
                numerador = n1 * d2 + n2 * d1;
                denominador = d1 * d2;
                mdc = CalcularMDC(numerador, denominador);
                ImprimirMDC(numerador, denominador, mdc);
            }
            else if (operador == '-')
            {
                numerador = n1 * d2 - n2 * d1;
                denominador = d1 * d2;
                mdc = CalcularMDC(numerador, denominador);
                ImprimirMDC(numerador, denominador, mdc);
            }
            else if (operador == '*')
            {
                numerador = n1 * n2;
                denominador = d1 * d2;
                mdc = CalcularMDC(numerador, denominador);
                ImprimirMDC(numerador, denominador, mdc);
            }
            else
            {
                numerador = n1 * d2;
                denominador = n2 * d1;
                mdc = CalcularMDC(numerador, denominador);
                ImprimirMDC(numerador, denominador, mdc);
            }
        }
    }

    static int CalcularMDC(int numerador, int denominador)
    {
        int resto;

        do
        {
            resto = numerador % denominador;
            numerador = denominador;
            denominador = resto;
        } while (resto != 0);

        return numerador;
    }

    static void ImprimirMDC(int numerador, int denominador, int mdc)
    {
        int n = numerador / mdc;
        int d = denominador / mdc;

        if (denominador < 0)
        {
            numerador *= -1;
            denominador *= -1;
        }

        if (d < 0)
        {
            n *= -1;
            d *= -1;
        }

        Console.WriteLine(numerador + "/" + denominador + " = " + n + "/" + d);

    }

}