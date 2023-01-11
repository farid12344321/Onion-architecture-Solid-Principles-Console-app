


using Homework_Practices.Controllers;
using ServiceLayer.Helpers;

LibrraryController librraryController = new();

while (true)
{
    GetOptions();

    Option: string option = Console.ReadLine();

    int selectedOption;

    bool isCorrectOption =int.TryParse(option, out selectedOption);

    if (isCorrectOption)
    {
        switch (selectedOption)
        {
            case 1:
                librraryController.Create();
                break;
            case 2:
                Console.WriteLine("Get all");
                break;
                case 3:
                Console.WriteLine("Delete");
                break;
            default:
                ConsoleColor.Red.WriteConsole("Please add correct options");
                goto Option;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Please add correct format options");
        goto Option;
    }
}

static void GetOptions()
{
    ConsoleColor.Cyan.WriteConsole("Please select one option : ");
    ConsoleColor.Cyan.WriteConsole("Library options : 1 - Create , 2 - Get all, 3 - Delete");
}
