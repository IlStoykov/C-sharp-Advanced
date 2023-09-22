int size = int.Parse(Console.ReadLine());
int primeSum = 0;
int secondarySum = 0;
int[,] matrix = new int[size, size];
for (int r = 0; r < size; r++) 
{
    int[] entr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int c = 0; c < size; c++) 
    {
        matrix[r, c] = entr[c];
    }
}
for (int i = 0; i < size; i++) 
{
    primeSum += matrix[i, i];
    secondarySum += matrix[i, size-1-i];
}
Console.WriteLine(Math.Abs(primeSum - secondarySum));

