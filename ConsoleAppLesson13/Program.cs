using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilding bilding = new Bilding();
            MultiBilding multiBilding = new MultiBilding();
            
            Console.Write("Введите адрес здания или застройки : ");
            bilding.Adress = Console.ReadLine();
            Console.Write("Введите длину главного фасада здания в мм : ");
            bilding.Lenghts = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину бокового фасада здания в мм : ");
            bilding.Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту здания в мм : ");
            bilding.Higth = Convert.ToInt32(Console.ReadLine());

            bilding.Print();
            Console.WriteLine();

            multiBilding.Adress = bilding.Adress;
            multiBilding.Lenghts = bilding.Lenghts;
            multiBilding.Width = bilding.Width;
            multiBilding.Higth = bilding.Higth;
            Console.Write("Введите этажность здания : ");
            multiBilding.Levels = Convert.ToInt32(Console.ReadLine());

            multiBilding.MultyPrint();

            Console.ReadKey();
        }
        public class Bilding
        {
            private protected string adress = "NAN";
            private protected int lenghts = 0; // В мм, как принято в строительной документации.
            private protected int width = 0; // В мм, как принято в строительной документации.
            private protected int hight = 0; // В мм, как принято в строительной документации.
            public Bilding ()
            { 
            }
            public string Adress 
            {
                set 
                {
                this .adress = value;
                }
                get 
                {
                return this .adress;
                }
            }
            public int Lenghts
            {
                set
                {
                    if (value > 0) this.lenghts = value;
                    else
                    {
                        this.lenghts = 0;
                        Console.WriteLine("Длина здания не может быть отрицательной или равной 0.");
                    }
                }
                get
                {
                    return this.lenghts;
                }
            }
            public int Width
            {
                set
                {
                    if (value > 0) this.width = value;
                    else
                    {
                        this.width = 0;
                        Console.WriteLine("Ширмна здания не может быть отрицательной или равной 0.");
                    }
                }
                get
                {
                    return this.width;
                }
            }
            public int Higth
            {
                set 
                {
                    if (value > 0) this.hight = value;
                    else 
                    { this.hight = 0;
                        Console.WriteLine("Высота здания не может быть отрицательной или равной 0.");
                    }
                }
                get 
                { 
                    return this .hight; 
                } 
            }
            public void Print()
            { 
                Console.WriteLine("Здание находится по адресу : {0}", Adress);
                Console.WriteLine("Ширины и гланого и бокового фасадов составляют соответственно : {0} и {1}", Lenghts, Width);
                Console.WriteLine("Высота здания составляет : {0}", Higth);
            }
        }
        sealed class MultiBilding : Bilding
        { 
            private int levels = 0; // этажность
            private const int MinLevelHight = 2700;
            
            public int Levels
            {
                set
                {
                    if (value > 1)
                    {
                        if (hight >= MinLevelHight)
                        {
                            if (value <= hight / MinLevelHight)
                            { 
                                this.levels = value; 
                            }
                            else
                            {
                                this.levels = this.hight / MinLevelHight;
                                Console.WriteLine("ЗДАНИЕ ТАКОЙ ВЫСОТЫ : {0} НЕ МОЖЕТ ИМЕТЬ ЭТАЖНОСТЬ БОЛЕЕ {1}", this.hight, this.levels);
                            }
                        }
                        else
                        {
                            this.levels = 1;
                            Console.WriteLine("ЗДАНИЕ ТАКОЙ ВЫСОТЫ : {0} НЕ МОЖЕТ ИМЕТЬ ЭТАЖНОСТЬ ОТЛИЧНУЮ ОТ 1", Higth);
                        }
                    }
                    else
                    {
                        this.levels = 1;
                        Console.WriteLine("ЗДАНИЕ НЕ МОЖЕТ ИМЕТЬ ЭТАЖНОСТЬ МЕНЕЕ 1");
                    }
                }
                
                get 
                { return levels; } 
            }

            public void MultyPrint()
            {
                Print();
                Console.WriteLine("Этажность здания составляет : {0}", levels);
            }
        }
    }
}
