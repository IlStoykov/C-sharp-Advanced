// See https://aka.ms/new-console-template for more information
int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] entr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int stackLength = values[0];
int valueToPop = values[1];
int valueTocheck = values[2];

Stack<int> stack = new Stack<int>(entr.Take(stackLength));

while (stack.Count > 0 && valueToPop > 0) 
{
    stack.Pop();
    valueToPop--;
}
if (stack.Contains(valueTocheck))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
{
    Console.WriteLine("0");
}
else 
{
    Console.WriteLine(stack.Min());
}



      
