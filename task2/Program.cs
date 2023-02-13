int[] CreateRandomArray(int lenght, int min, int max)
{
	int[] array = new int[lenght];
	Random random = new Random();
	for (int i = 0; i < lenght; i++)
	{
		array[i] = random.Next(min, max +1);
	}
	return array;
}

void SumOddPositionNumbers(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
		if (i % 2 != 0)
		{
			sum = sum + array[i];
		}
	}
	Console.WriteLine($" => {sum}");
}

int[] array = CreateRandomArray(4, -99, 100);
SumOddPositionNumbers(array);