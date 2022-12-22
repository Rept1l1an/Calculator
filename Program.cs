using System.Linq.Expressions;
int num1,num2,num3;
Console.WriteLine("Ededleri daxil edin:");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Emel novu secin");
string op = Console.ReadLine();
switch (op)
{
    case "+":
        Console.WriteLine("Toplama əməlini seçdiniz:");
        num3=num1 + num2;
        Console.WriteLine(num3);
        break;
    case "-":
        Console.WriteLine("Çıxma əməlini seçdiniz:");
        num3=num1 - num2;
        Console.WriteLine(num3);
        break;
    case "*":
        Console.WriteLine("Vurma əməlini seçdiniz:");
        num3=num1 * num2;
        Console.WriteLine(num3);
        break;
    case "/":
        Console.WriteLine("Bölmə əməlini seçdiniz:");
        num3= num1 / num2;
        Console.WriteLine(num3);
        break;
    case "%":
        Console.WriteLine("Qalığı seçdiniz:");
        num3= num1 % num2;
        Console.WriteLine(num3);
        break;
    default : Console.WriteLine("Are you serious ?");
        break;
}