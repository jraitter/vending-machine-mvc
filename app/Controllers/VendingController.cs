using System;
using System.Threading;
using vendingMachine_mvc.Models;
using vendingMachine_mvc.Services;

namespace vendingMachine_mvc.Controllers
{
  class VendingController
  {
    private bool _running { get; set; } = true;
    private VendingService _vss { get; set; } = new VendingService();

    public void Run()
    {
      Print();
      // Console.Clear();
      // Console.WriteLine("Welcome to the vending machine application");

      while (_running)
      {
        //take input
        GetUserInput();
        //process option
        //print update
        Print();
      }
    }

    private void GetUserInput()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine("\n");
      System.Console.Write(@"What would you like to do: 
'view' to see list of available beverages
'vend' to select a beverage
'add'  to enter quaters
'quit' to exit the application

Selection: ");
      string input = Console.ReadLine().Trim().ToLower();
      switch (input)
      {
        case "quit":
        case "exit":
        case "q":
          _running = false;
          _vss.Messages.Add(new Message("Good-bye", ConsoleColor.White));
          break;
        case "view":
          _vss.AddBeveragesToMessages();
          break;
        case "vend":
          System.Console.Write("Enter the number of the beverage: ");
          string indexString = Console.ReadLine();
          _vss.Vend(indexString);
          break;
        case "add":
          _vss.AddMoney();
          break;
        default:
          //number check here if not hanlding with "rent"
          _vss.Messages.Add(new Message("invalid Input", ConsoleColor.Red));
          Thread.Sleep(1500);
          break;
      }
    }

    private void Print()
    {
      Console.Clear();
      _vss.Messages.Insert(0, new Message(Utils.VendMachineLogo, ConsoleColor.Green));
      //itterate over messages and print each one
      foreach (Message message in _vss.Messages)
      {
        Console.ForegroundColor = message.Color;
        Console.WriteLine(message.Body);
      }
      _vss.Messages.Clear();
    }


  }//end of class
}//end of namespace