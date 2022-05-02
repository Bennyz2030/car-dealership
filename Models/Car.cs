using System;

namespace Dealership.Models 
{
  public class Car
  {
    public string MakeModel { get; set; }
    public float Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public void Sale(int discount)
    {
      Price *= ((100 - discount) / 100f);
    }

    public string RallyWorthy()
    {
      if (Miles < 200000)
      {
        return "Good to go.";
      }
      else
      {
        return "Don't drive in the desert with this car.";
      }
    }

    public float Resale(int year)
    {
      int modelYear = int.Parse(MakeModel.Split(" ")[0]);
      if (modelYear < year)
      {
        return Price - ((year - modelYear) * (Price * .05f));
      } 
      else
      {
        return Price;
      }
    }
  }
}