using System;
using vendingMachine_mvc.Controllers;


namespace vendingMachine_mvc
{
  class Program
  {
    static void Main(string[] args)
    {
      VendingController vc = new VendingController();
      vc.Run();
    }
  }
}
