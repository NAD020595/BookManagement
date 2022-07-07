using BookManagement.ConsoleApp.Controller;

BookController controller = new BookController();
while (true)
{
    Console.Write("Request> ");
    string request = Console.ReadLine();
    switch (request.ToLower())
    {
        case "single":
            controller.Single(1);
            break;
        case "create":
            controller.Create();
            break;
        default:
            Console.WriteLine("Unknown command");
            break;
    }
}