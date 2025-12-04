Console.WriteLine("Введите сумму вашего счета: ");
double invoiceAmount = double.Parse(Console.ReadLine());//ввести сумму счета
Console.WriteLine("Введите процент чаевых: ");
double tipPercentage = double.Parse(Console.ReadLine());//ввести процент чаевых
Console.WriteLine("Введите кол-во людей: ");
int groupSize = int.Parse(Console.ReadLine());//ввести кол-во людей в группе

double tipAmount = (invoiceAmount * tipPercentage) / 100;
Console.WriteLine($"Процент чаевых составляет: {tipPercentage}%.");
double totalAmount = invoiceAmount + tipAmount;
Console.WriteLine($"Общая сумма счета составляет: {totalAmount}.");
double equalAmount = totalAmount / groupSize;
Console.WriteLine($"С каждого: {equalAmount}.");









