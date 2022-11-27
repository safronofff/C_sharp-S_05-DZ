//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.0 7.2 22.7 2.1 78.3] -> 76.2

void ShowArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		System.Console.Write(array[i] + " ");
	}
	System.Console.WriteLine();
}

double MaxAndMin(double[] array)
{
	double max = 0;
	double min = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > max)
		{
			max = array[i];
		}
		if (array[i] < max)
		{
			min = array[i];
		}
	}
	double result = max - min;
	return result;
}

double[] array = { 3.0, 7.2, 22.7, 2.1, 78.3 };

ShowArray(array);
double maxandmin = MaxAndMin(array);
System.Console.WriteLine(maxandmin);