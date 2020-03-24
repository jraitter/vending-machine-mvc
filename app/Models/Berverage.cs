namespace vendingMachine_mvc.Models
{
  class Beverage
  {
    public Beverage(string name, BevType bevtype, float price)
    {
      Name = name;
      Bevtype = bevtype;
      Price = price;
      Available = true;
    }

    public string Name { get; set; }
    public BevType Bevtype { get; set; }
    public bool Available { get; set; }
    public float Price { get; set; }


  }//endof class
  enum BevType
  {
    soda,
    energyDrink,
    juice,
    water
  }
}//endof namespace