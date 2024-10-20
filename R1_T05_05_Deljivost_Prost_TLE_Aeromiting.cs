// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka3/aeromiting
// https://petlja.org/sr-Latn-RS/kurs/14606/23/2756
// https://onlinegdb.com/ra03R8wec
// https://github.com/draganilicnis/R1_T05_05_Deljivost_Prost_TLE_Aeromiting1/blob/main/R1_T05_05_Deljivost_Prost_TLE_Aeromiting.cs

using System;

class R1_T05_05_Deljivost_Prost_TLE_Aeromiting
{
    static long Dopuna_do_punog_kvadrata(long n)
    {
        long m = 1;
        long d = 2;
        while (d * d <= n)
        {
            int k = 0;
            while (n % d == 0)
            {
                n = n / d;
                k++;
            }
            if (k % 2 != 0) m = m * d;
            d++;
        }
        if (n > 1) m = m * n;
        return m;
    }
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long m = Dopuna_do_punog_kvadrata(n);
        Console.WriteLine(n/m);
    }
}
