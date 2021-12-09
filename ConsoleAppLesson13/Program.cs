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
            
            Console.Write("Введите адрес здания или застройки : ");
            bilding.Adress = Console.ReadLine();
            Console.Write("Введите длину главного фасада здания в мм : ");
            bilding.Lenghts = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину бокового фасада здания в мм : ");
            bilding.Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту здания в мм : ");
            bilding.Higth = Convert.ToInt32(Console.ReadLine());



            bilding.Print();

            Console.ReadKey();
        }
        public class Bilding
        {
            private string adress = "NAN";
            private int lenghts = 0; // В мм, как принято в строительной документации.
            private int width = 0; // В мм, как принято в строительной документации.
            private int hight = 0; // В мм, как принято в строительной документации.
            public Bilding ()
            { 
                // this .adress = _adress;
                // this .lenghts = _lenghts;
                // this .width = _width;
                // this .hight = _hight;
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
    }
}
