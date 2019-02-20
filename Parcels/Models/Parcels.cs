using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    private int _length;
    private int _height;
    private int _width;
    private int _weight;
    private int _volume;

    public Parcel (string length, string height, string width, string weight)
    {
      _length = int.Parse(length);
      _height = int.Parse(height);
      _width = int.Parse(width);
      _weight = int.Parse(weight);
    }

    public int GetHeight()
    {
        return _height;
    }

    public int GetLength()
    {
        return _length;
    }

    public int GetWidth()
    {
        return _width;
    }

    public int GetWeight()
    {
        return _weight;
    }

    public int Volume()
    {
        _volume = _height * _length * _width;
        return _volume;
    }


    public int GetPrice()
    {
        return _volume / 5000 + _weight / 50;
    }
  }
}
