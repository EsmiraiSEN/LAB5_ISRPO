using System;

Console.WriteLine("ЗАДАНИЕ 1");
Console.Write("Введите пароль: ");
string pass1 = Console.ReadLine();
Console.Write("Подтвердите пароль: ");
string pass2 = Console.ReadLine();
if (pass1 == pass2) {
    Console.WriteLine("Пароль принят");
} else {
    Console.WriteLine("Пароль не принят");
}

Console.WriteLine("ЗАДАНИЕ 2");
Console.Write("Введите ваш возраст: ");
if (int.TryParse(Console.ReadLine(), out int age)) {
    if (age >= 18) Console.WriteLine("Доступ разрешён");
    else Console.WriteLine("Доступ запрещён");
}

Console.WriteLine("ЗАДАНИЕ 3");
Console.Write("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine());
Console.Write("Введите операцию (+, -, *, /): ");
string op = Console.ReadLine();
switch (op) {
    case "+": Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); break;
    case "-": Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); break;
    case "*": Console.WriteLine($"{num1} * {num2} = {num1 * num2}"); break;
    case "/": 
        if (num2 != 0) Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        else Console.WriteLine("Ошибка: деление на ноль!");
        break;
    default: Console.WriteLine("Неверная операция!"); break;
}

Console.WriteLine("ЗАДАНИЕ 4");
int sumOfPositives = 0;
for (int i = 1; i <= 3; i++) {
    Console.Write($"Введите число {i}: ");
    int n = int.Parse(Console.ReadLine());
    if (n > 0) sumOfPositives += n;
}
Console.WriteLine($"Сумма положительных чисел: {sumOfPositives}");

Console.WriteLine("ЗАДАНИЕ 5");
Console.WriteLine("Вы стоите перед первой дверью. Выберите путь:");
Console.WriteLine("Путь A: Войти в комнату с огромным драконом.");
Console.WriteLine("Путь B: Пойти по тёмному коридору.");
Console.Write("Ваш выбор (A/B): ");
string pathChoice = Console.ReadLine().Trim().ToUpper();

if (pathChoice == "A") {
    Console.WriteLine("\nДракон говорит: 'Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.'");
    Console.Write("Ваш ответ: ");
    string answer = Console.ReadLine().Trim().ToLower();
    if (answer == "рыба") {
        Console.WriteLine("Дракон улыбнулся и открыл дверь к Dungeon Master'у! Победа!");
    } else {
        Console.WriteLine("Дракон съел вас! Игра окончена.");
    }
} else if (pathChoice == "B") {
    Console.WriteLine("\nПеред вами тёмная комната с двумя дверями.");
    Console.WriteLine("Дверь 1: Неизвестно что.");
    Console.WriteLine("Дверь 2: Неизвестно что.");
    Console.Write("Какую дверь выберете? (1/2): ");
    string doorChoice = Console.ReadLine().Trim();
    if (doorChoice == "1") {
        Console.WriteLine("Вы нашли легендарные сокровища Dungeon Master'а! Вы богаты!");
    } else {
        Console.WriteLine("Вы попали в ловушку с ядовитыми шипами и погибли...");
    }
} else {
    Console.WriteLine("Вы испугались и убежали.");
}
