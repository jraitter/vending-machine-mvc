using System;
using System.Collections.Generic;
using vendingMachine_mvc.Models;

namespace vendingMachine_mvc.Services
{
  class VendingService
  {
    private Store _store { get; set; } = new Store();
    public List<Message> Messages { get; set; } = new List<Message>();

    public void AddBeveragesToMessages()
    {
      Messages.Add(new Message($"Money available: ${_store.MoneyAvailable:0.00##}", ConsoleColor.Green));

      for (int i = 0; i < _store.Beverages.Count; i++)
      {
        var beverage = _store.Beverages[i];
        if (beverage.Available)
        {
          if (beverage is Soda)
          {
            var bevSoda = (Soda)beverage;
            string message = $"{i + 1}. Name: {bevSoda.Name} Diet: {bevSoda.IsDiet}  PRICE: {bevSoda.Price} Type: {bevSoda.Bevtype}";
            Messages.Add(new Message(message));
          }
          else if (beverage is EnergyDrink)
          {
            var bevEnergy = (EnergyDrink)beverage;
            string message = $"{i + 1}. Name: {bevEnergy.Name} Diet: {bevEnergy.IsDiet}  PRICE: {bevEnergy.Price} Type: {bevEnergy.Bevtype}";
            Messages.Add(new Message(message));
          }
          else if (beverage is Juice)
          {
            var bevJuice = (Juice)beverage;
            string message = $"{i + 1}. Name: {bevJuice.Name} Flavor: {bevJuice.Fruit}  PRICE: {bevJuice.Price} Type: {bevJuice.Bevtype}";
            Messages.Add(new Message(message));
          }
          else if (beverage is Water)
          {
            var bevWater = (Water)beverage;
            string message = $"{i + 1}. Name: {bevWater.Name}  Has Calories: {bevWater.HasCalories}  PRICE: {bevWater.Price} Type: {bevWater.Bevtype}";
            Messages.Add(new Message(message));
          }
          else
          {
            string message = $"{i + 1}. Name: {beverage.Name}  PRICE: {beverage.Price} Type: {beverage.Bevtype}";
            Messages.Add(new Message(message));
          }

        }//endof if bev avail

      }//endof for loop

    }

    public void Vend(string indexString)
    {
      if (int.TryParse(indexString, out int index) && index - 1 > -1 && index - 1 < _store.Beverages.Count)
      {
        Beverage bevToVend = _store.Beverages[index - 1];
        if (bevToVend.Available)
        {
          if (bevToVend.Price > _store.MoneyAvailable)
          {
            Messages.Add(new Message("This item costs more than currently in machine, please add more quarters ", ConsoleColor.Red));
            return;
          }
          bevToVend.Available = false;
          _store.MoneyAvailable -= bevToVend.Price;
          Messages.Add(new Message("Successfully vended out " + bevToVend.Name, ConsoleColor.Green));
          Messages.Add(new Message($"Change available: ${_store.MoneyAvailable:0.00##}, please pick up your change.\n", ConsoleColor.Green));
          _store.MoneyAvailable = 0;
          return;
        }
      }
      Messages.Add(new Message("Invalid Beverage Number", ConsoleColor.Red));
    }

    public void AddMoney()
    {
      _store.MoneyAvailable += .25f;
      Messages.Add(new Message($"Money available: ${_store.MoneyAvailable:0.00##}", ConsoleColor.Green));

    }

  }//end of class
}//end of namespace