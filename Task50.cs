class Task50
{

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет


    public static string Execute()
    {
         Random rnd = new Random();
         double[,] array = Task47.ArrayGenerator(rnd.Next(1,10), rnd.Next(1,10));

         Console.WriteLine("Дан массив\n");
         Console.WriteLine(Task47.PrintArray(array));


        int m=-100;
         int n=-100;

        while(m!=-1 || n!=-1){
            
        Console.WriteLine("Для остановки программы введите -1");
         m = MainClass.ReadInteger("Введите m строку для инициализации");
          if(m==-1 || n==-1)break;
         n = MainClass.ReadInteger("Введите n столбец  для инициализации");
         if(m==-1 || n==-1)break;

 
        if(m>array.GetLength(0) || n>array.GetLength(1)){Console.WriteLine("Такого элемента не существует ви сходном элементе"); continue;}

            string number= string.Format("{0:N2}", array[m,n]);
                if((array[m,n] % 1) == 0)number= ((int)array[m,n]).ToString();

                Console.WriteLine("Выбранное число "+number);
            
        }
        return "Задача 50 выполнена";


    }







}