namespace vendingMachine_mvc.Models
{
  class Water : Beverage
  {
    public Water(string name, BevType bevtype, float price, bool hasCalories) : base(name, bevtype, price)
    {
      HasCalories = hasCalories;
    }

    public bool HasCalories { get; set; }
  }
}