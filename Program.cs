using System;
using System.Text.RegularExpressions;

class MainClass
{
    public static void Main()
    {

        Console.WriteLine(Task47.Execute());
        Console.WriteLine(Task50.Execute());
        Console.WriteLine(Task52.Execute());
        // Console.WriteLine(Task2.Execute());

    }


    public static int ReadInteger(String msg)
    {

        Boolean itsOK = false;

        while (!itsOK)
        {
            Console.WriteLine(msg);

            try
            {
                String input = Console.ReadLine();
                String st = Regex.Replace(input, @"[^0-9-]", "");


                //  Console.WriteLine("поменяно "+st);
                if (st.Length == 0)
                {
                    Console.WriteLine("ошибка, введите число.");
                    continue;
                }


                int res = int.Parse(st);
                Console.WriteLine("(Введено число " + res + ")");
                return res;
            }
            catch (Exception) { continue; }
        }



        return 0;
    }

    public static double ReadDouble(String msg)
    {

        Boolean itsOK = false;

        while (!itsOK)
        {
            Console.WriteLine(msg);

            try
            {
                String input = Console.ReadLine();
                String st = Regex.Replace(input, "\\D", "");


                //  Console.WriteLine("поменяно "+st);
                if (st.Length == 0)
                {
                    Console.WriteLine("ошибка, введите число.");
                    continue;
                }


                double res = double.Parse(st);
                Console.WriteLine("(Введено число " + res + ")");
                return res;
            }
            catch (Exception) { continue; }
        }



        return 0;
    }

    static void Exception(Exception exception)
    {
        Console.WriteLine(exception);
        Environment.Exit(1);
    }
}