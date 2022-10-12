class Task52
{

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


    public static string Execute()
    {
        
        Random rnd = new Random();
         double[,] array = Task47.ArrayGenerator(rnd.Next(1,10), rnd.Next(1,10),true);

         Console.WriteLine("Дан массив\n");
         Console.WriteLine(Task47.PrintArray(array));





        return "\n Средние значения по столбцам \n"+GetAverangeByColumn(array);


    }

  static  string GetAverangeByColumn(double[,] array){
               String result = "";

        for (int i = 0; i < array.GetLength(1); i++)
        {

            double av=0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                av=av+array[j, i];
            }
           result = result +  (av/array.GetLength(0)) + "\t\t\t";
        }
       return result;

    }







}