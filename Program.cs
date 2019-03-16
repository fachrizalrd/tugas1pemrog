using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator by Fachrizal Rafif";
            Console.WriteLine("Pilih Menu");
            Console.WriteLine();

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();
            Console.Write("Input nomor menu [1-4] : ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (input > 4 || input < 1)
            {
                Console.WriteLine("Menu Tidak Tersedia");
                pesan();
            }
            else
            {
                Console.Write("Input nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input nilai b : ");
                int b = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
                }
                else if (input == 2)
                { 
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a,b));
                }
                else if (input == 3)
                { 
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a,b));
                }
                else if (input == 4)
                { 
                Console.WriteLine("Hasil Pembagiann {0} / {1} = {2}", a, b, pembagian(a,b));
                }
                pesan();
            }

            int penjumlahan (int a,int b)
            {
                return a + b;
            }

            int pengurangan(int a, int b)
            {
                return a - b;
            }

            int perkalian(int a, int b)
            {
                return a * b;
            }

            int pembagian(int a, int b)
            {
                return a / b;
            }


            void pesan ()
            {
                Console.WriteLine();
                Console.Write("Tekan sembarang untuk keluar . . .");
                Console.ReadKey();
            }



        }
    }
}
