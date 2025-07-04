using ConsoleApp.Controllers;
using ConsoleApp.Views;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BookController controller = new BookController();
controller.Single(0);
