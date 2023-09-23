using System.Text;

int[] startEntr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int rows = startEntr[0];
int cols = startEntr[1];

int result = 0;
int bestResult = 0;
int bestRow = 0;
int bestCol = 0;
int[,] resultMatrix = new int[3, 3];

int[,] matrix = new int[rows, cols];
for (int r = 0; r < rows; r++)
{
    int[] entr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int c = 0; c < cols; c++)
    {
        matrix[r, c] = entr[c];
    }
}
for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        result = calcMatrix(row, col, matrix);
        
        if (result > bestResult)
        {
            bestResult = result;
            bestRow = row;
            bestCol = col;
        }
    }
    
}
Console.WriteLine($"Sum = {bestResult}");
var stringResult = new StringBuilder();
for (int r = bestRow; r < bestRow + 3; r++) 
{
    for (int c = bestCol; c < bestCol + 3; c++) 
    {
        stringResult.Append(matrix[r, c] + " ");        
    }
    stringResult.AppendLine();
}
Console.WriteLine(stringResult.ToString().Trim());
static int calcMatrix(int row, int col, int[,] matrix)
{
    int result = 0;
    for (int r = 0; r < 3; r++) 
    {
        for (int c = 0; c < 3; c++) 
        {
            result += matrix[row + r, col + c];
        }
    }
    return result;
}

