

static int inputNumber(string request, string error)
{
    int number;
    Console.WriteLine(request);
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine(error);
    }
    return number;
}

static bool bool_input_value(string request)
{
    Console.WriteLine(request);
    string inputcharType = Console.ReadLine();
    return inputcharType.ToLower() == "ano";
}

static char choose_random_char(string str) {
    Random random = new Random();
    return str[random.Next(str.Length - 1)];
}

/*
static string GeneratePassword(int passwordLength, string usedChars)
{
    char[] password = new char[passwordLength];
    for (int i = 0; i < passwordLength; i++)
    {
        password[i] = choose_random_char(usedChars);
    }
    return String.Join(null, password);
}*/

static string GeneratePassword(int passwordLength, string usedChars)
{
    string password = "";
    for (int i = 0; i < passwordLength; i++)
    {
        password += choose_random_char(usedChars);
    }
    return password;
}

static void generator_hesla()
{
    int PasswordLength = inputNumber("Zadejte celočíselnou délku hesla", "Znova a lépe");

    string upperCase = "QWERTYUIOPASDFGHJKLZXCVBNM";
    string lowerCase = "qwertyuiopasdfghjklzxcvbnm";
    string Numbers = "0123456789";
    string specials = "!@#$%&*()-_=+<,>.";

    bool useLowercase = bool_input_value("Chcete použít malá písmena? Napiště ano/ne: ");
    bool useUppercase = bool_input_value("Chcete použít velká písmena? Napiště ano/ne: ");
    bool useNumbers = bool_input_value("Chcete použít čísla? Napiště ano/ne: ");
    bool useSpecial = bool_input_value("Chcete použít znaky? Napiště ano/ne: ");

    string usedChars = "";

    // Build up the character set to choose from
    if (useLowercase) usedChars += lowerCase;

    if (useUppercase) usedChars += upperCase;

    if (useNumbers) usedChars += Numbers;

    if (useSpecial) usedChars += specials;

    string heslo = GeneratePassword(PasswordLength, usedChars);

    Console.WriteLine($"Vaše nové vygenerované heslo: {heslo}");
}

generator_hesla();

Console.ReadLine();
