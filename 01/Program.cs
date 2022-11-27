// 1 - Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		System.Console.Write(array[i] + " ");
	}
	System.Console.WriteLine();
}

int Elemets(int[] array)
{
	int result = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			result = result + 1;
		}
	}
	return result;
}

int[] array = { 345, 897, 568, 234 };
ShowArray(array);
int result = Elemets(array);
System.Console.WriteLine($"количество четных чисел массива равно {result}");