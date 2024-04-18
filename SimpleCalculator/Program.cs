Console.Write("Informe o primeiro número: ");
float a = float.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
float b = float.Parse(Console.ReadLine());

Console.Write("Informe a operação (+, -, *, /): ");
char operation = Console.ReadLine().First();

while (true)
{
    bool validOperation =
        operation == '+' ||
        operation == '-' ||
        operation == '*' ||
        operation == '/';

    if (validOperation)
        break;

    Console.Write("Operação inválida, tente novamente (+, -, *, /): ");
    operation = Console.ReadLine().First();
}

while (operation == '/' && b == 0)
{
    Console.Write("Segundo número não pode ser zero ao dividir, digite outro valor: ");
    b = float.Parse(Console.ReadLine());
}

float result;

if (operation == '+')
    result = a + b;
else if (operation == '-')
    result = a - b;
else if (operation == '*')
    result = a * b;
else 
    result = a / b;

Console.WriteLine($"({a}) {operation} ({b}) = {result}");