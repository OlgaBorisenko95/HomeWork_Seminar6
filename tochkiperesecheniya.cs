int Input(string text)
{
    Console.Write(text);
    int argument = int.Parse(Console.ReadLine());
    return argument;
}

void CrossingPoints(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны.");
    else
    {

        double pointX = (b2 - b1) / (k1 - k2);
        double pointY = k1 * pointX + b1;
        Console.WriteLine($"Координата точки пересечения прямых: ({pointX}; {pointY})");
    }
}
int b1 = Input("Введите b1: ");
int k1 = Input("Введите k1: ");
int b2 = Input("Введите b2: ");
int k2 = Input("Введите k2: ");
CrossingPoints(b1, k1, b2, k2);
