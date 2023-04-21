using System;

class EriMath
{
    public static int obvodObdelniku(int a, int b)
    {
        return 2 * a + 2 * b;
    }

    public static int obvodCtverce(int a)
    {
        return 4 * a;
    }

    public static int obsahCtverce(int a)
    {
        return a * a;
    }

    public static double obvodTrojuhelniku(int a, int b, double c)
    {
        return a + b + c;
    }

    public static double preponaPravouhlehoTrojuhelniku(int a, int b)
    {
        return Math.Sqrt(a * a + b * b);
    }

    public static int soucetCifer(int number)
    {
        int zbytek = 0;
        int soucet = 0;
        while (number >= 10)
        {
            zbytek = number % 10;
            number = (number - zbytek) / 10;
            soucet += zbytek;
        }
        soucet += number;
        return soucet;
    }

    public static int soucinCifer(int number)
    {
        int soucin = 1;
        int zbytek = 0;
        while (number >= 10)
        {
            zbytek = number % 10;
            number = (number - zbytek) / 10;
            soucin *= zbytek;
        }
        soucin *= number;
        return soucin;
    }
}