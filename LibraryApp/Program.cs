
using LibraryApp.Controllers;
using Service.Enums;
using Service.Helpers.Extensions;

LibraryController libraryController = new();



while (true)
{
    GetMenues();

    Operation: string operationStr = Console.ReadLine();
    int operation;
    bool isCorrectOperation = int.TryParse(operationStr, out operation);

    if (isCorrectOperation)
    {

        switch (operation)
        {
            case (int)OperationTypes.LibraryCreate:
                libraryController.Create();
                break;
            case (int)OperationTypes.LibraryDelete:
                Console.WriteLine("delete");
                break;
            case (int)OperationTypes.LibraryGetAll:
                libraryController.GetAll();
                break;
            default:
                ConsoleColor.Red.WriteConsole("Operation is wrong, please try again : ");
                goto Operation;
        }


    }
    else
    {
        ConsoleColor.Red.WriteConsole("Operation format is wrong, please try again : ");
        goto Operation;
    }



}




static void GetMenues()
{
    ConsoleColor.Cyan.WriteConsole("Library operations : (1) - Create, (2) - Delete, (3) - GetAll");
}

