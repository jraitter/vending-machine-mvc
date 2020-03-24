namespace vendingMachine_mvc.Models
{
  class Soda : Beverage
  {
    public Soda(string name, BevType bevtype, float price, bool isDiet) : base(name, bevtype, price)
    {
      IsDiet = isDiet;
    }

    public bool IsDiet { get; set; }
  }
}