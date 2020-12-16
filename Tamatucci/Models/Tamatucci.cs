//Constructors and anything that modifies the object

 
  // these will be defiend by ints:
  // Feed, Play, Sleep  
  //It will die
  // ID number for all the tucci's
  //buttons

using System.Collections.Generic;

namespace TamaTucci.Models
{
  public class Tucci

  {
    public string TucciName { get; set;}
    public int Id { get; } //the program will handle this
    public int EnergyLevel { get; set; } //
    public int HappinessLevel { get; set; } //
    public int TirednessLevel { get; set; } //
    public int CleanlinessLevel { get; set; } //
    private static List<Tucci> _instances = new List<Tucci> {}; //this will hold all of our Tucci's

//Constructor that is building our Tucci
    public Tucci(string tucciName)
    {
      TucciName = tucciName;
      _instances.Add(this);
      Id = _instances.Count;
      EnergyLevel = 10;
      HappinessLevel = 10;
      TirednessLevel = 10;
      CleanlinessLevel = 10;
    }

    public static List<Tucci> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Tucci Find(int ID)
    {
      return _instances[ID - 1];
    }


  // {}
}
}