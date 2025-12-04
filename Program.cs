Console.WriteLine("Введите сумму вашего счета: ");
string invoiceAmount_str = Console.ReadLine();//ввести сумму счета
if (double.TryParse(invoiceAmount_str, out double invoiceAmount))
{
    Console.WriteLine("Введите процент чаевых: ");
}
else
{
    Console.WriteLine("Ошибка запустите программу заново!!!");
}
string tipPercentage_str = Console.ReadLine();//ввести процент чаевых
if (double.TryParse(tipPercentage_str, out double tipPercentage))
{
    Console.WriteLine("Введите кол-во людей: ");
}
else
{
    Console.WriteLine("Ошибка запустите программу заново!!!");
}
string groupSize_str = Console.ReadLine();//ввести кол-во людей в группе
if (double.TryParse(groupSize_str, out double groupSize))
{
    double tipAmount = (invoiceAmount * tipPercentage) / 100;
    Console.WriteLine($"Процент чаевых составляет: {tipPercentage}%.");
    double totalAmount = invoiceAmount + tipAmount;
    Console.WriteLine($"Общая сумма счета составляет: {totalAmount}.");
    double equalAmount = totalAmount / groupSize;
    Console.WriteLine($"С каждого: {equalAmount}.");
}
else
{
    Console.WriteLine("Ошибка запустите программу заново!!!");
}








