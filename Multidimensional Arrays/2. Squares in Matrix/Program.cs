int[] startEntr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int rows = startEntr[0];
int cols = startEntr[1];

int result = 0;

char[,] matrix = new char[rows, cols];
for (int r = 0; r < rows; r++) 
{
    char[] entr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int c = 0; c < cols; c++) 
    {
        matrix[r, c] = entr[c];
    }
}
for (int row = 0; row < rows - 1; row++) 
{
    for (int col = 0; col < cols - 1; col++) 
    {
        if (square(row, col, matrix)) 
        {
            result++;
        }
    }
}
Console.WriteLine(result);
static bool square(int row, int col, char[,] matrix) 
{
    char symbol = matrix[row, col];
    if (matrix[row, col + 1] == symbol && matrix[row + 1, col + 1] == symbol && matrix[row + 1, col] == symbol) 
    {
        return true;
    }
    else { return false; }
}
