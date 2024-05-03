using System;
using System.Reflection.Emit;

Console.Title = "Carpenter's radar";
Console.Clear();
while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Нажмите любую клавишу, чтобы войти в систему...");
    Console.ResetColor();
    Console.ReadKey(true);
    Console.Clear();
    
    Console.WriteLine("                   Y                     ");
    Console.WriteLine(".++***************+@*******************%:");
    Console.WriteLine(".*-             1 -=                   +:");
    Console.WriteLine(".*:               -=                   +:");
    Console.WriteLine(".*:               -=                   +:");
    Console.WriteLine(".*:               -=                   +:");
    Console.WriteLine(".*:               -=                   +:");
    Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
    Console.WriteLine(".*- -1            -=                1  +:");
    Console.WriteLine(".*:               -=                   +:");
    Console.WriteLine(".*:               -=                   +:");
    Console.WriteLine(".*:               -=                   +:");
    Console.WriteLine(".*:            -1 -=                   +:");
    Console.WriteLine(".++***************+@*******************%:");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Вы можете дислоцировать бойца в любую из клеток на сетке размером 2х2.");
    Console.ReadKey(true);
    Console.WriteLine("Координатная сетка представлена выше.");
    Console.ReadKey(true);
    Console.WriteLine("Поскольку наша военная разработка CAPRENTERTAR является экспериментальной,\nвы можете использовать только целые числа для ввода координат.");
    Console.ReadKey(true);
    Console.WriteLine("Для данной сетки типа CAPRI_01 этими цифрами будут только 1 и -1");
    Console.ReadKey(true);
    Console.WriteLine("Мы сможем развить нашу технологию, если получим достаточно финансирования.\nДля этого нам нужно получить разрешение от Ильи Мязина.");
    Console.ReadKey(true);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Пожалуйста, введите координату X: ");
    Console.ResetColor();
    string xCoordinateText = Console.ReadLine();
    int xCoordinate = Convert.ToInt32(xCoordinateText);
    while (xCoordinate != 1 && xCoordinate != -1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Вы ввели некоректное число. Введите координату X снова: ");
        Console.ResetColor();
        xCoordinateText = Console.ReadLine();
        xCoordinate = Convert.ToInt32(xCoordinateText);

    }
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Пожалуйста, введите координату Y: ");
    Console.ResetColor();
    string yCoordinateText = Console.ReadLine();
    int yCoordinate = Convert.ToInt32(yCoordinateText);
    while (yCoordinate != 1 && yCoordinate != -1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Вы ввели некоректное число. Введите координату Y снова: ");
        Console.ResetColor();
        yCoordinateText = Console.ReadLine();
        yCoordinate = Convert.ToInt32(yCoordinateText);
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Задана точка А с координатами ({xCoordinate}, {yCoordinate})");
    Console.ResetColor();
    if (xCoordinate == 1 && yCoordinate == 1)
    {
        Console.WriteLine("                   Y                     ");
        Console.WriteLine(".++***************+@*******************%:");
        Console.WriteLine(".*-             1 -=                   +:");
        Console.WriteLine(".*:               -=     NUKE HERE     +:");
        Console.WriteLine(".*:               -=     NUKE HERE     +:");
        Console.WriteLine(".*:               -=     NUKE HERE     +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
        Console.WriteLine(".*- -1            -=                1  +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:            -1 -=                   +:");
        Console.WriteLine(".++***************+@*******************%:");
    }
    else if (xCoordinate == 1 && yCoordinate == -1)
    {
        Console.WriteLine("                   Y                     ");
        Console.WriteLine(".++***************+@*******************%:");
        Console.WriteLine(".*-             1 -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
        Console.WriteLine(".*- -1            -=                1  +:");
        Console.WriteLine(".*:               -=     NUKE HERE     +:");
        Console.WriteLine(".*:               -=     NUKE HERE     +:");
        Console.WriteLine(".*:               -=     NUKE HERE     +:");
        Console.WriteLine(".*:            -1 -=                   +:");
        Console.WriteLine(".++***************+@*******************%:");
    }
    else if (xCoordinate == -1 && yCoordinate == 1)
    {
        Console.WriteLine("                   Y                     ");
        Console.WriteLine(".++***************+@*******************%:");
        Console.WriteLine(".*-             1 -=                   +:");
        Console.WriteLine(".*:   NUKE HERE   -=                   +:");
        Console.WriteLine(".*:   NUKE HERE   -=                   +:");
        Console.WriteLine(".*:   NUKE HERE   -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
        Console.WriteLine(".*- -1            -=                1  +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:            -1 -=                   +:");
        Console.WriteLine(".++***************+@*******************%:");
    }
    else if (xCoordinate == -1 && yCoordinate == -1)
    {
        Console.WriteLine("                   Y                     ");
        Console.WriteLine(".++***************+@*******************%:");
        Console.WriteLine(".*-             1 -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*:               -=                   +:");
        Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
        Console.WriteLine(".*- -1            -=                1  +:");
        Console.WriteLine(".*:   NUKE HERE   -=                   +:");
        Console.WriteLine(".*:   NUKE HERE   -=                   +:");
        Console.WriteLine(".*:   NUKE HERE   -=                   +:");
        Console.WriteLine(".*:            -1 -=                   +:");
        Console.WriteLine(".++***************+@*******************%:");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Приступаем к дислоцированию...\nНажмите любую клавишу, чтобы подтвердить запрос.");
    Console.ReadKey(true);
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ВНИМАНИЕ! СВЯЗЬ С КОМАНДНЫМ ЦЕНТРОМ ПРЕРВАНА!");
    Console.ReadKey(true);
    Console.WriteLine("ПРОГРАММА: ЗАМЕЧЕН ВРАЖДЕБНЫЙ ЭЛЕМЕНТ");
    Console.ReadKey(true);
    Console.WriteLine("ПРОГРАММА: ПЕРЕХОД В АВТОНОМНЫЙ РЕЖИМ");
    Console.ReadKey(true);
    Console.WriteLine("ВРАЖДЕБНЫЙ ЭЛЕМЕНТ: СВЯЗЬ УСТАНОВЛЕНА");
    Console.ReadKey(true);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Что ты наделал!? Как ты не сразу не понял!?\nВедь эта программа не дислоцирует бойцов! Она пускает ядерку!");
    Console.ReadKey(true);
    Console.WriteLine("Я знаю, ты всего лишь совершил ошибку... Я не буду тебя винить...");
    Console.ReadKey(true);
    Console.WriteLine("Я программист из Горхонска... Как только наши радары засекли ракеты, я сразу начал штурм льда вашей прошивки.");
    Console.ReadKey(true);
    Console.WriteLine("Опомнись! Помоги мне определить, в какой квадрат ты запустил ракету!");
    Console.ReadKey(true);
    Console.WriteLine("Просто назови координаты запуска... Поверь, я не останусь в должниках.");
    Console.ReadKey(true);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Пожалуйста, скажи, какой ты вписал X? ");
    Console.ResetColor();
    string checkXCoordinateText = Console.ReadLine();
    int checkXCoordinate = Convert.ToInt32(checkXCoordinateText);
    while (checkXCoordinate != 1 && checkXCoordinate != -1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Этого не может быть!\nКоординаты вашей машины не выходят за пределы 1 и -1");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Попробуй ещё раз! Введи координату Х: ");
        Console.ResetColor();
        checkXCoordinateText = Console.ReadLine();
        checkXCoordinate = Convert.ToInt32(checkXCoordinateText);
    }
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Отлично! Теперь назови координату Y: ");
    Console.ResetColor();
    string checkYCoordinateText = Console.ReadLine();
    int checkYCoordinate = Convert.ToInt32(checkYCoordinateText);
    while (checkYCoordinate != 1 && checkYCoordinate != -1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Этого не может быть!\nКоординаты вашей машины не выходят за пределы 1 и -1");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Попробуй ещё раз! Введи координату Y: ");
        Console.ResetColor();
        checkYCoordinateText = Console.ReadLine();
        checkYCoordinate = Convert.ToInt32(checkYCoordinateText);
    }

    
        if (checkXCoordinate == 1 && checkYCoordinate == 1)
        {
            Console.WriteLine("                   Y                     ");
            Console.WriteLine(".++***************+@*******************%:");
            Console.WriteLine(".*-             1 -=                   +:");
            Console.WriteLine(".*:               -=     ?????????     +:");
            Console.WriteLine(".*:               -=     ?????????     +:");
            Console.WriteLine(".*:               -=     ?????????     +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
            Console.WriteLine(".*- -1            -=                1  +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:            -1 -=                   +:");
            Console.WriteLine(".++***************+@*******************%:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Я должен проверить эти координаты... Дай мне секундочку...");
        Console.ReadKey(true);

        if (checkXCoordinate == xCoordinate && checkYCoordinate == yCoordinate)
            {
                Console.WriteLine("Да, это здесь! Ты выбрал этот квадрат!");
            Console.ReadKey(true);
            Console.WriteLine("Спасибо! Благодаря тебе у нас ещё есть время, чтобы провести эвакуацию!");
            Console.ReadKey(true);
            Console.WriteLine("Я ещё свяжусь с тобой, Илья Мязин. Мне кажется, можем стать отличными напарниками.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ПРОГРАММА: ВРАЖДЕБНЫЙ ЭЛЕМЕНТ ЛИКВИДИРОВАН");
            Console.ReadKey(true);
            Console.WriteLine("СИСТЕМА: ВОЗВРАЩЕНИЕ К ШТАТНОМУ РЕЖИМУ РАБОТЫ");
            Console.ReadKey(true);
            Console.ResetColor ();
            }
            else
            {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Нет... Координаты не верны! Ракета запущена не туда!");
            Console.ReadKey(true);
            Console.WriteLine("Давай повторим... Ещё раз! Пока ещё есть время...");
            Console.ReadKey(true);

            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.WriteLine("С-стой... Что это за звуки?...");
            Console.ReadKey(true);
            Console.WriteLine("О н-нет... Слишком поздно...");
            Console.ReadKey(true);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 1000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("..........................................");
            Console.WriteLine(". ....................................... ");
            Console.WriteLine(". ..................--...-............... ");
            Console.WriteLine("..........----.-:::**:.-----............. ");
            Console.WriteLine("-........*+++=+++=+=+=*:--::::-.......... ");
            Console.WriteLine("..-.-*=+++%%@@===%%%%%==+-:**::--.........");
            Console.WriteLine("-..*++%%%@@%=%%#@%@@@%%=*-*+**:::-........");
            Console.WriteLine("-..=%%%%@#@###@@@##@@%%=:-++***::--...... ");
            Console.WriteLine("-..-%%@@@@@###@@###@@%=:+%==++**:-........");
            Console.WriteLine("-..-=@@###@##########@#@@%%==+**::::--....");
            Console.WriteLine("-.-.*@@@################@@%=++*****:::-...");
            Console.WriteLine("-.---.+#@#@##############@@%=++***:::-....");
            Console.WriteLine("-.-----.:%###########@@@@%===++***:-......");
            Console.WriteLine(":---------..==%@#####@@##%=++-............");
            Console.WriteLine(":------------+=@###@####@%=++:.-.-....--..");
            Console.WriteLine(":--:---------*+%#######@%=+++:-------.....");
            Console.WriteLine("-.----------.-=%@#####@##%=+:.............");
            Console.WriteLine("-.-----------.-=@###@@@%##@+-.............");
            Console.WriteLine("------------..-....%#@@%:.................");
            Console.WriteLine(":-:--------------.:%@#@@*.................");
            Console.WriteLine("*:::::-----------.*@@#%@*.---.............");
            Console.WriteLine(":::::-----------.*@@%@=@=-.-----.....----.");
            Console.WriteLine("-.-------------.+##@%@%%@*.--------------.");
            Console.WriteLine("-.-----.-----.-=#%#@@##%@#=--------------.");
            Console.WriteLine("-.---........-++=%@#@%##@@@+--.----------.");
            Console.WriteLine(". ........*@@#@@@###@@##@%=###%%=%%%=*-:**");
            Console.WriteLine("%%%=@@##@%%@%%%==%@%%%%%%%%%=@@%=%%======+");
            Console.WriteLine("%====+===%=================%%%==========++");
            Console.WriteLine("%========%%%%%%%%@@%%%%%@@%@@@%@%%@@#####@");
            Console.WriteLine("%%%%%%%%%%@@@@###@###########@@@##########");
            Console.WriteLine("@@@@@@@###################################");
            Console.WriteLine("##########################################");
            Console.ResetColor();
            Console.ReadKey(true);



        }

        }
        if (checkXCoordinate == 1 && checkYCoordinate == -1)
        {
            Console.WriteLine("                   Y                     ");
            Console.WriteLine(".++***************+@*******************%:");
            Console.WriteLine(".*-             1 -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
            Console.WriteLine(".*- -1            -=                1  +:");
            Console.WriteLine(".*:               -=     ?????????     +:");
            Console.WriteLine(".*:               -=     ?????????     +:");
            Console.WriteLine(".*:               -=     ?????????     +:");
            Console.WriteLine(".*:            -1 -=                   +:");
            Console.WriteLine(".++***************+@*******************%:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Я должен проверить эти координаты... Дай мне секундочку...");
            if (checkXCoordinate == xCoordinate && checkYCoordinate == yCoordinate)
            {
            Console.WriteLine("Да, это здесь! Ты выбрал этот квадрат!");
            Console.ReadKey(true);
            Console.WriteLine("Спасибо! Благодаря тебе у нас ещё есть время, чтобы провести эвакуацию!");
            Console.ReadKey(true);
            Console.WriteLine("Я ещё свяжусь с тобой, Илья Мязин. Мне кажется, можем стать отличными напарниками.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ПРОГРАММА: ВРАЖДЕБНЫЙ ЭЛЕМЕНТ ЛИКВИДИРОВАН");
            Console.ReadKey(true);
            Console.WriteLine("СИСТЕМА: ВОЗВРАЩЕНИЕ К ШТАТНОМУ РЕЖИМУ РАБОТЫ");
            Console.ReadKey(true);
            Console.ResetColor();
        }
            else
            {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Нет... Координаты не верны! Ракета запущена не туда!");
            Console.ReadKey(true);
            Console.WriteLine("Давай повторим... Ещё раз! Пока ещё есть время...");
            Console.ReadKey(true);

            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.WriteLine("С-стой... Что это за звуки?...");
            Console.ReadKey(true);
            Console.WriteLine("О н-нет... Слишком поздно...");
            Console.ReadKey(true);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 1000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("..........................................");
            Console.WriteLine(". ....................................... ");
            Console.WriteLine(". ..................--...-............... ");
            Console.WriteLine("..........----.-:::**:.-----............. ");
            Console.WriteLine("-........*+++=+++=+=+=*:--::::-.......... ");
            Console.WriteLine("..-.-*=+++%%@@===%%%%%==+-:**::--.........");
            Console.WriteLine("-..*++%%%@@%=%%#@%@@@%%=*-*+**:::-........");
            Console.WriteLine("-..=%%%%@#@###@@@##@@%%=:-++***::--...... ");
            Console.WriteLine("-..-%%@@@@@###@@###@@%=:+%==++**:-........");
            Console.WriteLine("-..-=@@###@##########@#@@%%==+**::::--....");
            Console.WriteLine("-.-.*@@@################@@%=++*****:::-...");
            Console.WriteLine("-.---.+#@#@##############@@%=++***:::-....");
            Console.WriteLine("-.-----.:%###########@@@@%===++***:-......");
            Console.WriteLine(":---------..==%@#####@@##%=++-............");
            Console.WriteLine(":------------+=@###@####@%=++:.-.-....--..");
            Console.WriteLine(":--:---------*+%#######@%=+++:-------.....");
            Console.WriteLine("-.----------.-=%@#####@##%=+:.............");
            Console.WriteLine("-.-----------.-=@###@@@%##@+-.............");
            Console.WriteLine("------------..-....%#@@%:.................");
            Console.WriteLine(":-:--------------.:%@#@@*.................");
            Console.WriteLine("*:::::-----------.*@@#%@*.---.............");
            Console.WriteLine(":::::-----------.*@@%@=@=-.-----.....----.");
            Console.WriteLine("-.-------------.+##@%@%%@*.--------------.");
            Console.WriteLine("-.-----.-----.-=#%#@@##%@#=--------------.");
            Console.WriteLine("-.---........-++=%@#@%##@@@+--.----------.");
            Console.WriteLine(". ........*@@#@@@###@@##@%=###%%=%%%=*-:**");
            Console.WriteLine("%%%=@@##@%%@%%%==%@%%%%%%%%%=@@%=%%======+");
            Console.WriteLine("%====+===%=================%%%==========++");
            Console.WriteLine("%========%%%%%%%%@@%%%%%@@%@@@%@%%@@#####@");
            Console.WriteLine("%%%%%%%%%%@@@@###@###########@@@##########");
            Console.WriteLine("@@@@@@@###################################");
            Console.WriteLine("##########################################");
            Console.ResetColor();
            Console.ReadKey(true);
        }
        }
        if (checkXCoordinate == -1 && checkYCoordinate == 1)
        {
            Console.WriteLine("                   Y                     ");
            Console.WriteLine(".++***************+@*******************%:");
            Console.WriteLine(".*-             1 -=                   +:");
            Console.WriteLine(".*:  ?????????    -=                   +:");
            Console.WriteLine(".*:  ?????????    -=                   +:");
            Console.WriteLine(".*:  ?????????    -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
            Console.WriteLine(".*- -1            -=                1  +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:            -1 -=                   +:");
            Console.WriteLine(".++***************+@*******************%:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Я должен проверить эти координаты... Дай мне секундочку...");
            if (checkXCoordinate == xCoordinate && checkYCoordinate == yCoordinate)
            {
            Console.WriteLine("Да, это здесь! Ты выбрал этот квадрат!");
            Console.ReadKey(true);
            Console.WriteLine("Спасибо! Благодаря тебе у нас ещё есть время, чтобы провести эвакуацию!");
            Console.ReadKey(true);
            Console.WriteLine("Я ещё свяжусь с тобой, Илья Мязин. Мне кажется, можем стать отличными напарниками.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ПРОГРАММА: ВРАЖДЕБНЫЙ ЭЛЕМЕНТ ЛИКВИДИРОВАН");
            Console.ReadKey(true);
            Console.WriteLine("СИСТЕМА: ВОЗВРАЩЕНИЕ К ШТАТНОМУ РЕЖИМУ РАБОТЫ");
            Console.ReadKey(true);
            Console.ResetColor();
        }
            else
            {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Нет... Координаты не верны! Ракета запущена не туда!");
            Console.ReadKey(true);
            Console.WriteLine("Давай повторим... Ещё раз! Пока ещё есть время...");
            Console.ReadKey(true);

            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.WriteLine("С-стой... Что это за звуки?...");
            Console.ReadKey(true);
            Console.WriteLine("О н-нет... Слишком поздно...");
            Console.ReadKey(true);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 1000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("..........................................");
            Console.WriteLine(". ....................................... ");
            Console.WriteLine(". ..................--...-............... ");
            Console.WriteLine("..........----.-:::**:.-----............. ");
            Console.WriteLine("-........*+++=+++=+=+=*:--::::-.......... ");
            Console.WriteLine("..-.-*=+++%%@@===%%%%%==+-:**::--.........");
            Console.WriteLine("-..*++%%%@@%=%%#@%@@@%%=*-*+**:::-........");
            Console.WriteLine("-..=%%%%@#@###@@@##@@%%=:-++***::--...... ");
            Console.WriteLine("-..-%%@@@@@###@@###@@%=:+%==++**:-........");
            Console.WriteLine("-..-=@@###@##########@#@@%%==+**::::--....");
            Console.WriteLine("-.-.*@@@################@@%=++*****:::-...");
            Console.WriteLine("-.---.+#@#@##############@@%=++***:::-....");
            Console.WriteLine("-.-----.:%###########@@@@%===++***:-......");
            Console.WriteLine(":---------..==%@#####@@##%=++-............");
            Console.WriteLine(":------------+=@###@####@%=++:.-.-....--..");
            Console.WriteLine(":--:---------*+%#######@%=+++:-------.....");
            Console.WriteLine("-.----------.-=%@#####@##%=+:.............");
            Console.WriteLine("-.-----------.-=@###@@@%##@+-.............");
            Console.WriteLine("------------..-....%#@@%:.................");
            Console.WriteLine(":-:--------------.:%@#@@*.................");
            Console.WriteLine("*:::::-----------.*@@#%@*.---.............");
            Console.WriteLine(":::::-----------.*@@%@=@=-.-----.....----.");
            Console.WriteLine("-.-------------.+##@%@%%@*.--------------.");
            Console.WriteLine("-.-----.-----.-=#%#@@##%@#=--------------.");
            Console.WriteLine("-.---........-++=%@#@%##@@@+--.----------.");
            Console.WriteLine(". ........*@@#@@@###@@##@%=###%%=%%%=*-:**");
            Console.WriteLine("%%%=@@##@%%@%%%==%@%%%%%%%%%=@@%=%%======+");
            Console.WriteLine("%====+===%=================%%%==========++");
            Console.WriteLine("%========%%%%%%%%@@%%%%%@@%@@@%@%%@@#####@");
            Console.WriteLine("%%%%%%%%%%@@@@###@###########@@@##########");
            Console.WriteLine("@@@@@@@###################################");
            Console.WriteLine("##########################################");
            Console.ResetColor();
            Console.ReadKey(true);
        }
        }
        if (checkXCoordinate == -1 && checkYCoordinate == -1)
        {
            Console.WriteLine("                   Y                     ");
            Console.WriteLine(".++***************+@*******************%:");
            Console.WriteLine(".*-             1 -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*:               -=                   +:");
            Console.WriteLine(".*=+++++++++++++++=@+++++++++++++++++@:+: X");
            Console.WriteLine(".*- -1            -=                1  +:");
            Console.WriteLine(".*:  ????????     -=                   +:");
            Console.WriteLine(".*:  ????????     -=                   +:");
            Console.WriteLine(".*:  ????????     -=                   +:");
            Console.WriteLine(".*:            -1 -=                   +:");
            Console.WriteLine(".++***************+@*******************%:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Я должен проверить эти координаты... Дай мне секундочку...");
            if (checkXCoordinate == xCoordinate && checkYCoordinate == yCoordinate)
            {
            Console.WriteLine("Да, это здесь! Ты выбрал этот квадрат!");
            Console.ReadKey(true);
            Console.WriteLine("Спасибо! Благодаря тебе у нас ещё есть время, чтобы провести эвакуацию!");
            Console.ReadKey(true);
            Console.WriteLine("Я ещё свяжусь с тобой, Илья Мязин. Мне кажется, можем стать отличными напарниками.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ПРОГРАММА: ВРАЖДЕБНЫЙ ЭЛЕМЕНТ ЛИКВИДИРОВАН");
            Console.ReadKey(true);
            Console.WriteLine("СИСТЕМА: ВОЗВРАЩЕНИЕ К ШТАТНОМУ РЕЖИМУ РАБОТЫ");
            Console.ReadKey(true);
            Console.ResetColor();
        }
            else
            {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Нет... Координаты не верны! Ракета запущена не туда!");
            Console.ReadKey(true);
            Console.WriteLine("Давай повторим... Ещё раз! Пока ещё есть время...");
            Console.ReadKey(true);

            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.WriteLine("С-стой... Что это за звуки?...");
            Console.ReadKey(true);
            Console.WriteLine("О н-нет... Слишком поздно...");
            Console.ReadKey(true);
            Console.Beep(440, 100);
            Console.Beep(440, 100);
            Console.Beep(440, 1000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("..........................................");
            Console.WriteLine(". ....................................... ");
            Console.WriteLine(". ..................--...-............... ");
            Console.WriteLine("..........----.-:::**:.-----............. ");
            Console.WriteLine("-........*+++=+++=+=+=*:--::::-.......... ");
            Console.WriteLine("..-.-*=+++%%@@===%%%%%==+-:**::--.........");
            Console.WriteLine("-..*++%%%@@%=%%#@%@@@%%=*-*+**:::-........");
            Console.WriteLine("-..=%%%%@#@###@@@##@@%%=:-++***::--...... ");
            Console.WriteLine("-..-%%@@@@@###@@###@@%=:+%==++**:-........");
            Console.WriteLine("-..-=@@###@##########@#@@%%==+**::::--....");
            Console.WriteLine("-.-.*@@@################@@%=++*****:::-...");
            Console.WriteLine("-.---.+#@#@##############@@%=++***:::-....");
            Console.WriteLine("-.-----.:%###########@@@@%===++***:-......");
            Console.WriteLine(":---------..==%@#####@@##%=++-............");
            Console.WriteLine(":------------+=@###@####@%=++:.-.-....--..");
            Console.WriteLine(":--:---------*+%#######@%=+++:-------.....");
            Console.WriteLine("-.----------.-=%@#####@##%=+:.............");
            Console.WriteLine("-.-----------.-=@###@@@%##@+-.............");
            Console.WriteLine("------------..-....%#@@%:.................");
            Console.WriteLine(":-:--------------.:%@#@@*.................");
            Console.WriteLine("*:::::-----------.*@@#%@*.---.............");
            Console.WriteLine(":::::-----------.*@@%@=@=-.-----.....----.");
            Console.WriteLine("-.-------------.+##@%@%%@*.--------------.");
            Console.WriteLine("-.-----.-----.-=#%#@@##%@#=--------------.");
            Console.WriteLine("-.---........-++=%@#@%##@@@+--.----------.");
            Console.WriteLine(". ........*@@#@@@###@@##@%=###%%=%%%=*-:**");
            Console.WriteLine("%%%=@@##@%%@%%%==%@%%%%%%%%%=@@%=%%======+");
            Console.WriteLine("%====+===%=================%%%==========++");
            Console.WriteLine("%========%%%%%%%%@@%%%%%@@%@@@%@%%@@#####@");
            Console.WriteLine("%%%%%%%%%%@@@@###@###########@@@##########");
            Console.WriteLine("@@@@@@@###################################");
            Console.WriteLine("##########################################");
            Console.ResetColor();
            Console.ReadKey(true);
        }
        }





    
} 
    