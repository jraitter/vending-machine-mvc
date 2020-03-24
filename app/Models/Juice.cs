namespace vendingMachine_mvc.Models
{
  class Juice : Beverage
  {
    public Juice(string name, BevType bevtype, float price, string fruit) : base(name, bevtype, price)
    {
      Fruit = fruit;
    }

    public string Fruit { get; set; }
  }
}