using System.Collections.Concurrent;

int[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = coordinates[0];
int cols = coordinates[1];
string[,] matrix = new string[rows, cols];
for (int r = 0; r < rows; r++) 
{
    string [] entr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int c = 0; c < cols; c++) 
    {
        matrix[r, c] = entr[c];
    }
}
string command = Console.ReadLine();
while (command != "END") 
{
    if (isValid(command, rows, cols))
    {
        string[] splitComand = command.Split(" ");
        string element1 = matrix[int.Parse(splitComand[1]), int.Parse(splitComand[2])];
        string element2 = matrix[int.Parse(splitComand[3]), int.Parse(splitComand[4])];

        matrix[int.Parse(splitComand[1]), int.Parse(splitComand[2])] = element2;
        matrix[int.Parse(splitComand[3]), int.Parse(splitComand[4])] = element1;

        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write(matrix[r, c] + " ");
            }
            Console.WriteLine();
        }
    }
    else 
    {
        Console.WriteLine("Invalid input!");
    }
    command = Console.ReadLine();

}
static bool isValid(string command, int rows, int cols) 
{
    string[] command1 = command.Split(" ");
    if (command1.Length != 5) 
    {
        return false;
    }
    string move = command1[0];
    int r1 = int.Parse(command1[1]);
    int c1 = int.Parse(command1[2]);
    int r2 = int.Parse(command1[3]);
    int c2 = int.Parse(command1[4]);
    if (move == "swap" && (r1 >=0 && r1< rows) && (r2 >= 0 && r2 < rows) 
        && (c1 >= 0 && c1 < cols) && (c2 >= 0 && c2 < cols))
    {
        return true;
    }
    else 
    {
        return false;
    }

}
