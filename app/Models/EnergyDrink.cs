namespace vendingMachine_mvc.Models
{
  class EnergyDrink : Beverage
  {
    public EnergyDrink(string name, BevType bevtype, float price, bool isDiet) : base(name, bevtype, price)
    {
      IsDiet = isDiet;
    }

    public bool IsDiet { get; set; }
  }
}