Console.Clear();
Console.WriteLine("введите число");
double n = Convert.ToDouble(Console.ReadLine());
for(double i= 1; i <= n; i++){

    Console.WriteLine(Math.Pow(i, 3));
}
