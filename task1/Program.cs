int[] CreateRandomArray(int lenght, int min, int max)
{
	int[] array = new int[lenght];
	Random random = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(min, max +1);
	}
	return array;
}

void EvenNumbers(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
		if (array[i] % 2 == 0)
		{
			count++;
		}
	}
	Console.WriteLine($" => {count}");
}

int[] array = CreateRandomArray(4, 100, 1000);
EvenNumbers(array);
