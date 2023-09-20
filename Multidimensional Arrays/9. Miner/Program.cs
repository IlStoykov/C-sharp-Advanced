int size = int.Parse(Console.ReadLine());
string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int collectedCoal = 0;
int currentRow = 0, currentCol = 0;

char[,] matrix = new char[size, size];
for (int row = 0; row < size; row++)
{
    char[] entr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = entr[col];
        if (entr[col] == 's')
        {
            currentRow = row;
            currentCol = col;
        }
        if (entr[col] == 'c')
        {
            collectedCoal++;
        }
    }
}

foreach (string direct in directions)
{
    switch (direct)
    {
        case "left":
            if (currentCol - 1 >= 0 && currentCol < size)
            {
                currentCol--;
            }
            if (matrix[currentRow, currentCol] == 'e')
            {
                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                return;
            }
            else if (matrix[currentRow, currentCol] == 'c')
            {
                matrix[currentRow, currentCol] = '*';
                collectedCoal--;
                if (collectedCoal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                    return;
                }
            }
            break;

        case "right":
            if (currentCol >= 0 && currentCol < size - 1)
            {
                currentCol++;
            }
            if (matrix[currentRow, currentCol] == 'e')
            {
                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                return;
            }
            else if (matrix[currentRow, currentCol] == 'c')
            {
                matrix[currentRow, currentCol] = '*';
                collectedCoal--;
                if (collectedCoal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                    return;
                }
            }
            break;

        case "up":
            if (currentRow -1 >= 0 && currentRow < size)
            {
                currentRow--;
            }
            if (matrix[currentRow, currentCol] == 'e')
            {
                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                return;
            }
            else if (matrix[currentRow, currentCol] == 'c')
            {
                matrix[currentRow, currentCol] = '*';
                collectedCoal--;
                if (collectedCoal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                    return;
                }
            }
            break;

        case "down":
            if (currentRow >= 0 && currentRow < size - 1)
            {
                currentRow++;
            }
            if (matrix[currentRow, currentCol] == 'e')
            {
                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                return;
            }
            else if (matrix[currentRow, currentCol] == 'c')
            {
                matrix[currentRow, currentCol] = '*';
                collectedCoal--;
                if (collectedCoal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                    return;
                }
            }
            break;
    }
}
Console.WriteLine($"{collectedCoal} coals left. ({currentRow}, {currentCol})");

