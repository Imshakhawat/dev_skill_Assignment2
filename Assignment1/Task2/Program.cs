
Console.Write("Size of Array :");

int size = Convert.ToInt32(Console.ReadLine());


int largest = Int32.MinValue;
int secondLargest = Int32.MinValue;
int thirdLargest = Int32.MinValue;

for (int i = 0; i < size; i++)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (input > largest)
    {
        thirdLargest = secondLargest;
        secondLargest = largest;
        largest = input;
    }
    else if (input > secondLargest)
    {
        thirdLargest = secondLargest;
        secondLargest = input;
    }
    else if (input > thirdLargest)
    {
         thirdLargest = input;
    }
       
}


Console.WriteLine("Third Largest number: " + thirdLargest);
