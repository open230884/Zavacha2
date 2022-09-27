string[] arr = new string[7] { "Понедельник", "Вторник", "Среда", "Четверег", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите число, которое взбредет вам в голову от 1 до 7");
int n = int.Parse(Console.ReadLine());

if (n<1 || n>7)
{
Console.WriteLine("Ввведено неверное число");

}
else
{
Console.WriteLine($"{n} - это {arr[n-1]}");
}