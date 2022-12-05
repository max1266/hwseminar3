Console.Clear();
Console.WriteLine("введите число");
string? n = Convert.ToString(Console.ReadLine());
if((n[0] == n[4]) && (n[1] == n[3])){
    Console.WriteLine("true");
}
else{
    Console.WriteLine("false");
}
