Console.Write("Informe o primeiro número: ");
float a = float.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
float b = float.Parse(Console.ReadLine());

while (b == 0)
{
    Console.Write("Segundo número não pode ser zero, digite outro valor: ");
    b = float.Parse(Console.ReadLine());
}

Console.Write("Informe o terceiro número: ");
float c = float.Parse(Console.ReadLine());

while (c == 0)
{
    Console.Write("Terceiro número não pode ser zero, digite outro valor: ");
    c = float.Parse(Console.ReadLine());
}

Console.Write("Informe o quarto número: ");
float d = float.Parse(Console.ReadLine());

while (d == 0)
{
    Console.Write("Quarto número não pode ser zero, digite outro valor: ");
    d = float.Parse(Console.ReadLine());
}

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

float result;

switch (operation)
{
    case '+':
        result = a + b + c + d;
        break;
    case '-':
        result = a - b - c - d;
        break;
    case '*':
        result = a * b * c * d;
        break;
    default:
        result = a / b / c / d;
        break;
}

Console.WriteLine($"({a}) {operation} ({b}) {operation} ({c}) {operation} ({d}) = {result}");