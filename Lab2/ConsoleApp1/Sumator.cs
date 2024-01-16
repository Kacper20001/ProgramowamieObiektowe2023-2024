using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Sumator
{
    private double[] Liczby;

    public Sumator(double[] liczby)
    {
        Liczby = liczby;
    }

    public double Suma()
    {
        double suma = Liczby.Sum();
        Console.WriteLine("suma: "+suma);
        return suma;
    }

    public double SumaPodziel2()
    {
        double sumaPodziel = 0;
        foreach (var item in Liczby)
        {
            if (item % 2 == 0)
            {
                sumaPodziel += item;
            }
        }
        Console.WriteLine("suma podziel2: " + sumaPodziel);
        return sumaPodziel;
    }

    public int IleElementów()
    {
        int elementyIlosc = Liczby.Length;
        Console.WriteLine(elementyIlosc);
        return elementyIlosc;
    }

    public void WypiszElementy()
    {
        foreach (var item in Liczby)
        {
            Console.WriteLine(item);
        }
    }

    public void WypiszElementyIndex(int lowindex, int highindex)
    {
        if (lowindex < 0)
        {
            lowindex = 0;
        }
        if (highindex >= Liczby.Length)
        {
            highindex = Liczby.Length - 1;
        }
        for (int i = lowindex; i <= highindex; i++)
        {
            Console.WriteLine(Liczby[i]);
        }
    }
}