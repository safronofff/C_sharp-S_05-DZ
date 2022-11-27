
// 2 - Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		System.Console.Write(array[i] + " ");
	}
	System.Console.WriteLine();
}

int SumElements(int[] array)
{
	int result = 0;
	for (int i = 1; i < array.Length; i = i + 2)
	{
		result = result + array[i];
	}
	return result;
}

//int[] array = { 3, 7, 23, 12 };
int[] array = { -4, -6, 89, 6 };

ShowArray(array);

int result = SumElements(array);
System.Console.WriteLine(result);