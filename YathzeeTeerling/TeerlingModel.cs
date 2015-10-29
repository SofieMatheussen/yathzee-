using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
  public class TeerlingModel
  {
    private int _aantalOgen; // aantal ogen per teerling
    private bool isVast;
    private bool toonWerp = false;

    //getters en setters van aantal ogen
    public int Aantalogen 
    {
      get
      {
        return _aantalOgen;
      }
      set
      {
        _aantalOgen = value;
      }
    }
    
    //waarde van bool opvragen
    public bool Vast
    {
      get
      {
        return isVast;
      }
      set
      {
        isVast = value;
      }
    }
    
    //waarde van de bool opvragen
    public bool Werp
    {
      get
      {
        return toonWerp;
      }
      set
      {
        toonWerp = value;
      }
    }
  }
}