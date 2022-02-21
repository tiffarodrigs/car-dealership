using System;
namespace Dealership.Models{
  public  class Car{
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string makeModel,int price,int miles)
    {
      _makeModel=makeModel;
      _price=price;
      _miles=miles; 
    }
    public string MakeModel{
      get{
        return _makeModel;
      }
      set{
        _makeModel=value;
      }
    }
    public int Price{
      get{
        return _price;
      }
      set{
        _price=value;
      } 
    }
    public int Miles{
      get{
        return _miles;
      }
      set{
        _miles=value;
      }
    }
    public bool WorthBuying(int maxPrice){
    return (_price<maxPrice);
    }

  }
}