class Task47
{

    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9


    public static string Execute()
    {

        int m = MainClass.ReadInteger("Введите m строк");
        int n = MainClass.ReadInteger("Введите n столбцов");


        double[,] array = ArrayGenerator(m, n);

        return PrintArray(array);

    }


  public  static double[,] ArrayGenerator(int m, int n,Boolean integersGen=false)
    {
        double[,] array = new double[m, n];

        Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.NextDouble() * (rnd.NextDouble() < 0.5 ? -1 : 1) * rnd.Next();
                if(integersGen)array[i, j]=(int)array[i, j];
            }
        }

        return array;
    }

  public  static string PrintArray(double[,] array)
    {

        String result = "";

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                string number= string.Format("{0:N2}", array[i, j]);
                if((array[i, j] % 1) == 0)number= ((int)array[i, j]).ToString();
                result = result +  number + "\t\t\t";

            }
            result = result + "\n_________________\n";
        }
       return result;
    }



}