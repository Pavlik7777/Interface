//Наследование от интерфейсов
//Номер 79
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] mas = new double[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите элемент {i + 1}: ");
    mas[i] = double.Parse(Console.ReadLine()!);
}
IContainer bubble = new Bubble(mas);
bubble.Sort();
bubble.Foreach();
IContainer choice = new Choice(mas);
choice.Sort();
choice.Foreach();
interface IContainer
{
    void Sort();
    void Foreach();
}

class Bubble : IContainer
{
    private double[] fing;
    private void Result(string message)
    {
        Console.WriteLine(message);
        foreach (double ris in fing)
            Console.Write($"{ris:F2} ");
        Console.WriteLine();
    }
    public Bubble(double[] mas)
    {
        fing = (double[])mas.Clone();
    }
    public void Sort()
    {
        for (int i = 0; i < fing.Length - 1; i++)
        {
            for (int j = 0; j < fing.Length - i - 1; j++)
            {
                if (fing[j] > fing[j + 1])
                {
                    double temp = fing[j];
                    fing[j] = fing[j + 1];
                    fing[j + 1] = temp;
                }
            }
        }
        Result("Отсортированный массив методом пузырька:");
    }
    public void Foreach()
    {
        Console.WriteLine("Квадратные корни элементов:");
        foreach (double ris in fing)
        {
            if (ris >= 0)
                Console.Write($"{Math.Sqrt(ris):F2} ");
            else
                Console.Write("Не получится ");
        }
        Console.WriteLine();
    }
}
class Choice : IContainer
{
    private double[] fing;

    public Choice(double[] mas)
    {
        fing = (double[])mas.Clone();
    }
    private void Result(string message)
    {
        Console.WriteLine(message);
        foreach (double ris in fing)
            Console.Write($"{ris:F2} ");
        Console.WriteLine();
    }
    public void Sort()
    {
        for (int i = 0; i < fing.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < fing.Length; j++)
            {
                if (fing[j] < fing[min])
                    min = j;
            }

            double temp = fing[i];
            fing[i] = fing[min];
            fing[min] = temp;
        }
        Result("Отсортированный массив методом выбора:");
    }

    public void Foreach()
    {
        Console.WriteLine("Логарифмы элементов:");
        foreach (double ris in fing)
        {
            if (ris > 0)
                Console.Write($"{Math.Log(ris):F2} ");
            else
                Console.Write("Не получится ");
        }
        Console.WriteLine();
    }
}
