using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasa_Sayılar
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Sayi ust sinirini girin: ");
            int sayiadedi = int.Parse(Console.ReadLine());
            
            for (int sayi = 2; sayi <= sayiadedi; sayi++)
            {
                bool asal = true;

                for (int j = 2; j <= Math.Sqrt(sayi); j++)
                {
                    if (sayi % j == 0)
                    {
                        asal = false;
                        break;
                    }
                }

                if (asal)
                {
                    bool Lasa = true;
                    string tersSayiStr = new string(sayi.ToString().Reverse().ToArray());
                    int tersSayi = int.Parse(tersSayiStr);
                    for (int j = 2; j <= Math.Sqrt(tersSayi); j++)
                    {
                        if (tersSayi % j == 0)
                        {
                            Lasa = false;
                            break;
                        }
                    }
                    if (Lasa)
                    {
                        Console.Write(sayi + " ");
                    }
                }

            }
        }
    }
}
