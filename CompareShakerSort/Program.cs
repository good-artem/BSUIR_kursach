using System.Diagnostics;

int[] BubleSort(int[] arr)
{
    var sv = new Stopwatch();
    sv.Start();
    int temp = 0;

    for (int write = 0; write < arr.Length; write++)
    {
        for (int sort = 0; sort < arr.Length - 1; sort++)
        {
            if (arr[sort] > arr[sort + 1])
            {
                temp = arr[sort + 1];
                arr[sort + 1] = arr[sort];
                arr[sort] = temp;
            }
        }
        //Console.Write("{0} ", arr[write]);
    }
    sv.Stop();
    Console.WriteLine("Время выполнения сортировки пузырьком: " + sv.Elapsed);
    return arr;
}
static void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}
static void CocktailSort(int[] inArray)
{
    var sv = new Stopwatch();
    sv.Start();
    int left = 0,
         right = inArray.Length - 1;
    while (left < right)
    {
        for (int i = left; i < right; i++)
        {
            if (inArray[i] > inArray[i + 1])
                Swap(inArray, i, i + 1);
        }
        right--;
        for (int i = right; i > left; i--)
        {
            if (inArray[i - 1] > inArray[i])
                Swap(inArray, i - 1, i);
        }
        left++;
    }
    sv.Stop();
    Console.WriteLine("Время выполнения шейкерной сортировки: " + sv.Elapsed);
}
void PrintMas(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("");
}

Console.WriteLine("Добро пожаловать!");
Console.WriteLine("Данная программа сравнивает алгоритмы сортировки, а именно пузызьковую и шейкерную\n");
Console.WriteLine("Введите количество элементов для сортировки:");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = new int[n];
Random random = new Random();

//Console.WriteLine("\nНеотсортированный массив:");
for (int i = 0;i< n; i++)
{
    mas[i] = random.Next(0, 100);
    //Console.Write(mas[i] + " ");
}
Console.WriteLine("");

int[] masBuble = mas;
int[] masShaker = mas;

//Console.WriteLine("\nОтсортированный методом пузырька массив:");
BubleSort(masBuble);
//PrintMas(masBuble);

//Console.WriteLine("\nОтсортированный шейкерным методом массив:");
CocktailSort(masShaker);
//PrintMas(masShaker);





