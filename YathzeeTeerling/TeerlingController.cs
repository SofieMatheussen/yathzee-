using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YathzeeTeerling
{
    // Vergeet niet de controller op public te zetten
    // Zo kan de view die de controller als argument meekrijgt aan de properties
    public class TeerlingController
  {
    // Member die de view en model en controller gaan onthouden 
    private TeerlingView _view;
    private YahtzeeController _controllerYahtzee;
    public TeerlingModel _model;

        static int seeder = new Random().Next(); //nodig omdat anders random getal altijd hetzelfde is
        Random random = new Random(++seeder); //random getal genereren

    public TeerlingController(YahtzeeController controller ) //constructor
    {
     // Maak een instantie van de view
     // Geef een de huidige instantie (= controller = this) mee als argument
    //kan communiceren als er event heeft plaatsgevonden
      _view = new TeerlingView(this); 
                                      
      _model = new TeerlingModel(); //maakt instantie van model aan
      _controllerYahtzee = controller;
    }

    public TeerlingView getView()
    {
      return _view; //return huidige view
    }
        //methode om teerling te werpen
    public void werpTeerling()
    {
      YahtzeeModel _modelYahtzee = _controllerYahtzee.getModel();
      if (!_model.Vast && _modelYahtzee.AantalWorpen <= _modelYahtzee.MaxAantalWorpen)
      {
        int teerlingGetal = random.Next(1, 7); //random tussen 1 en 6
        _model.Aantalogen = teerlingGetal; //random getal doorsturen naar model
      }
    }

    public void toggleVast()
    {
      _model.Vast = !_model.Vast;
    }

    public void resetTeerling()
    {
      _model.Aantalogen = 0;
      _model.Vast = false;
      _view.updateUI();
    }
  }
}
