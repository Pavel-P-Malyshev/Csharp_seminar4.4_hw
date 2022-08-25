/*
Задача 3. Со Звездочкой (*). 
Сгенерировать двумерный массив со случайными числами, вывести его на экран, 
оформить в виде функций (пригодится в дальнейшем)

*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}



int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix=new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j]=new Random().Next(1,10);

        }
        
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} [{i},{j}] ");

        }
        Console.WriteLine();
    }

}
int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int[,] matr=FillMatrix(r,c);
System.Console.WriteLine("Generated matrix is: ");
PrintMatrix(matr);
