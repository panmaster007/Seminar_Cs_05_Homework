int[] CreateRandomArray(int lenght, int min, int max)
{
	int[] array = new int[lenght];
	Random random = new Random();
	for (int i = 0; i < lenght; i++)
	{
		array[i] = random.Next(min, max + 1);
	}
	return array;
}

void DifferenceMinMaxNumbers(int[] array)
{
	int max = 0;
	int min = 0;
	if (array[0] > array[1])
	{
		max = array[0];
		min = array[1];
	}
	else
	{
		max = array[1];
		min = array[0];
	}
	int i = 2;
	while (i < array.Length)
	{
		if (array[i] > max)
		{
			max = array[i];
		}
		else if (array[i] < min)
		{
			min = array[i];
		}
		i++;
	}
	int difference = max - min;
	Console.Write(string.Join(" ", array));
	Console.Write($" => {difference}");
}

int[] array = CreateRandomArray(4, 0, 100);
DifferenceMinMaxNumbers(array);