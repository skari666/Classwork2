string st = Console.ReadLine();
char result;
bool prov = Char.TryParse(st, out result);
if (prov)
{
    Console.WriteLine("Символ");
}
int result1;
bool prov1 = Int32.TryParse(st, out result1);
if (prov1 && !prov)
{
    Console.WriteLine("Целое число");
}
double result2;
bool prov2 = Double.TryParse(st, out result2);
if (prov2 && !prov1)
{
    Console.WriteLine("Дробное число");
}
bool result3;
bool prov3 = Boolean.TryParse(st, out result3);
if (prov3 && !prov2)
{
    Console.WriteLine("Логическое");
}
