using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2semFunkcijas_2_2_MGrITIA3
{
    internal class Program
    {
        static void Main()

        // Garš un stulbs kods, bet strādājošs ¯\_(ツ)_/¯
        {
            Console.Write("Ievadiet masīva rindu skaitu: ");
            int rindas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadiet masīva kolonnu skaitu: ");
            int kolonnas = Convert.ToInt32(Console.ReadLine());


            int[,] mas = new int[rindas, kolonnas];

            InitMas(mas);
            PrintMas(mas);

            // Izvada funkciju min
            int min = MinMas(mas);
            Console.WriteLine($"Masīva min vertība: {min}");
            
            // Izvada funkciju max
            int max = MaxMas(mas);
            Console.WriteLine($"Masīva max vertība: {max}");

            // User inputs un funkcija meklet
            Console.Write("Ievadiet skaitli kuru meklēt: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            int meklet = Meklet(mas, skaitlis);
            Console.WriteLine($"Skaitlis {skaitlis} masīvā atkārtojas {meklet}");
        }

        static void InitMas(int[,] mas)
        {
            Console.WriteLine();
            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(1, 10);
                }
            }
        }
        static void PrintMas(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int MinMas(int[,] mas)
        {
            //Lai nenočakarē min vērtības meklēšanu
            int min = int.MaxValue;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                    }
                }
            }
            return min;
        }

        static int MaxMas(int[,] mas)
        {
            // Tas pats kas ar min ))
            int max = int.MinValue;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                    }
                }
            }
            return max;
        }

        static int Meklet(int[,] mas, int meklet)
        { // Nu jā, kautkā tā...
            int skaitlis = 0;
            foreach(int cipars in mas)
                if (cipars == meklet)
                {
                    skaitlis++;
                }
            return skaitlis;
        }
    }
}

