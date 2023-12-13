using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Areas
{
    public class Ex23
    {
        public static void Main()
        {
            int select;
            const string MSG = "Benvingut a la calculadora d'arees. Introdueix la opció que vols utilitzar: \n" +
                "1. Quadrat\n" +
                "2. Rectangle\n" +
                "3. Cercle\n" +
                "4. Pentàgon",
                MSGSQ = "Introdueix el costat del quadrat: ", MSGRECT = "Introdueix la base del rectangle: ",
                MSG2RECT = "Introdueix la alçada del rectangle: ", MSGCIRC = "Introdueix el radi del cercle: ",
                MSGPENT = "Introdueix l'apotema del pentàgon: ", MSG2PENT = "Introdueix el costat del pentàgon: ",
                NEGATIVE = "No existeixen mesures negatives. ";
            double x, y;
            do
            {
                Console.WriteLine(MSG);
                select = Convert.ToInt32(Console.ReadLine());
            } while (!(select >= 1 && select <= 4));
            switch (select)
            {
                case 1:
                    do
                    {
                        Console.Write(MSGSQ);
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x > 0)
                        {
                            Console.Write(NEGATIVE);
                        }
                    } while (x > 0);
                    Console.WriteLine(Square(x));
                    break;
                case 2:
                    do
                    {
                        Console.Write(MSGRECT);
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write(MSG2RECT);
                        y = Convert.ToDouble(Console.ReadLine());
                        if (x > 0 || y > 0)
                        {
                            Console.Write(NEGATIVE);
                        }
                    } while (x > 0 || y > 0);
                    Console.WriteLine(Rectangle(x, y));
                    break;
                case 3:
                    do
                    {
                        Console.Write(MSGCIRC);
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x > 0)
                        {
                            Console.Write(NEGATIVE);
                        }
                    } while (x > 0);
                    Console.WriteLine(Circle(x));
                    break;
                case 4:
                    do
                    {
                        Console.Write(MSGPENT);
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Write(MSG2PENT);
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x > 0 || y > 0)
                        {
                            Console.Write(NEGATIVE);
                        }
                    } while (x > 0 || y > 0);
                    Console.WriteLine(Pentagon(x, y));
                    break;
            }
        }
        public static double Square(double x)
        {

            return x * x;
        }
        public static double Rectangle(double x, double y)
        {
            return x * y;
        }
        public static double Circle(double x)
        {
            return x * x * Math.PI;
        }
        public static double Pentagon(double x, double y)
        {
            return x * 5 * y / 2;
        }
    }
}