using System.Collections.Generic;

namespace vendingMachine_mvc.Models
{
  class Store
  {
    public List<Beverage> Beverages { get; set; }
    public float MoneyAvailable { get; set; } = 0;

    public Store()
    {
      Beverages = new List<Beverage>()
      {
        // Implicit casting from berverate to beverage type.
        new Soda("Pepsi",BevType.soda, .75f, false),
        new Soda("Coke Zero", BevType.soda, .75f, true),
        new EnergyDrink("Monster", BevType.energyDrink, 1.25f, false),
        new Juice("TreeTop", BevType.juice, .95f, "Apple"),
        new Juice("Welches", BevType.juice, .95f, "Grape"),
        new Water("Mt. Springs", BevType.water, .50f, false),
        new Water("Active Water", BevType.water, .85f, true)
      };
    }
  }
}