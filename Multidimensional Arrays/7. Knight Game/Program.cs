using System.Data;

int size = int.Parse(Console.ReadLine());
int taskResult = 0;
char[,] matrix = new char[size, size];
if (size <= 2) 
{
    Console.WriteLine(0);
    return;
}
for (int r = 0; r < size; r++) 
{
    char[] entr = Console.ReadLine().ToArray();
    for (int c = 0; c < size; c++) 
    {
        matrix[r, c] = entr[c];
    }
}
while (true) 
{
    int bestResult = 0;
    int bestRow = 0;
    int bestCol = 0;
    for (int row = 0; row < size; row++) 
    {
        for (int col = 0; col < size; col++) 
        {
            if (matrix[row, col] == 'K') 
            {
                int tempResult = knightCheck(row, col, matrix, size);
                if (tempResult > bestResult)
                {
                    bestResult = tempResult;
                    bestRow = row;
                    bestCol = col;
                }
            }
            
        }
    }
    if (bestResult != 0)
    {
        matrix[bestRow, bestCol] = '0';
        taskResult++;
    }
    else 
    {
        break;
    }
}
Console.WriteLine(taskResult);
static int knightCheck(int row, int col, char[, ]matrix, int size) 
{
    int result = 0;
    if (isValid(row - 2, col + 1, size) && matrix[row - 2, col + 1] == 'K') 
    {
        result++;
    }
    if (isValid(row - 1, col + 2, size) && matrix[row - 1, col + 2] == 'K')
    {
        result++;
    }
    if (isValid(row + 1, col + 2, size) && matrix[row + 1, col + 2] == 'K')
    {
        result++;
    }
    if (isValid(row + 2, col + 1, size) && matrix[row + 2, col + 1] == 'K')
    {
        result++;
    }
    if (isValid(row + 2, col - 1, size) && matrix[row + 2, col - 1] == 'K')
    {
        result++;
    }
    if (isValid(row + 1, col - 2, size) && matrix[row + 1, col - 2] == 'K')
    {
        result++;
    }
    if (isValid(row - 1, col - 2, size) && matrix[row - 1, col - 2] == 'K')
    {
        result++;
    }
    if (isValid(row - 2, col - 1, size) && matrix[row - 2, col - 1] == 'K')
    {
        result++;
    }
    return result;
}
static bool isValid(int row, int col, int size) 
{
    return row >= 0 && col >= 0 && row < size && col < size;
}