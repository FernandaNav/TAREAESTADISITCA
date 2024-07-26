int option = 0, numbersAmount;

do
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("   Statistical Calculations"); Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine();
    Console.WriteLine("Option 1: Enter numbers");
    Console.WriteLine("Option 2: Mean");
    Console.WriteLine("Option 3: Median");
    Console.WriteLine("Option 4: Mode");
    Console.WriteLine("Option 5: Standard Deviation");
    Console.WriteLine("Option 6: Exit");
    Console.WriteLine(); Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Choose an option: ");
    try
    {
        option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("        Enter numbers"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                FillArray();
                break;
            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("             Mean"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                break;
            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("           Median "); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                break;
            case 4:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("             Mode"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                break;
            case 5:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("      Standard Deviation"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                break;
            case 6:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|          Good Bye :)        |"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                break;
            default:
                break;
        }
    }
    catch (FormatException)
    {
        ExceptionMessage();
    }
    Console.ResetColor();
} while (option != 6);


static void ExceptionMessage()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Format Error. Try again.");
    ContinureMessage();
}
static void ContinureMessage()
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Press any key to continue..."); Console.ForegroundColor = ConsoleColor.Cyan;
    Console.ReadKey(); Console.Clear(); Console.ResetColor();
}
static int[] FillArray()
{
    int numbersAmount;
    while (true)
    {
        try
        {
            Console.Write("How many numbers do you want to enter?: ");
            numbersAmount = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {

        }
        int[] numbers = new int[numbersAmount];

        for (int i = 0; i < numbersAmount; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers;
    }
}