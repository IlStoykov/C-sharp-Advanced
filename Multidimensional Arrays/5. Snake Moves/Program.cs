int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
char[] entr = Console.ReadLine().ToCharArray();

int rows = dimentions[0];
int cols = dimentions[1];

char[, ] matrix = new char[rows, cols];

int charCount = 0;

int currentRow = 1;

for (int r = 0; r < rows; r++)
{
    if (currentRow % 2 != 0)
    {
        for (int c = 0; c < cols; c++)
        {
            if (charCount == entr.Length)
            {
                charCount = 0;
            }
            matrix[r, c] = entr[charCount];
            charCount++;
        }
        
    }
    else
    {
        for (int c = cols-1; c >= 0; c--)
        {
            if (charCount == entr.Length)
            {
                charCount = 0;
            }
            matrix[r, c] = entr[charCount];
            charCount++;            
            
        }
        
    }
    currentRow++;
}
for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < cols; r++) 
    {
        Console.Write(matrix[r, c]);
    }
    Console.WriteLine();
}