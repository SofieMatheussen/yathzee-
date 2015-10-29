using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
  public class YahtzeeController
  {
    private YahtzeeView _view;
    private YahtzeeModel _model;
    
    public YahtzeeController() //constructor
    {
     // Maak een instantie van de view
     // Geef een de huidige instantie (= controller = this) mee als argument
     //kan communiceren als er event heeft plaatsgevonden
      _view = new YahtzeeView(this);

     // Maak een nieuwe instantie van het model aan
     _model = new YahtzeeModel();
    }

   
    public YahtzeeModel getModel()
    {
      return _model;
    }

    public YahtzeeView getView()
    {
      return _view;
    }

        public List<TeerlingView> getTeerlingenView()
    {
      // lijst die de views opvangt
      List<TeerlingView> teerlingenView = new List<TeerlingView>();

      // Loop over het huidig aantal teerlingen uit het model
      foreach (TeerlingController teerling in getModel().Teerlingen)
      {
        // Haal de view op voor iedere teerling
        TeerlingView teerlingView = teerling.getView();

        // Voeg de teerling toe aan de lijst die de views opvangt
        teerlingenView.Add(teerlingView);
      }

      // Return de lijst met teerlingViews
      return teerlingenView;
    }

    public void initialize()
    {
      maakTeerlingen();
    }

    private void maakTeerlingen()
    {
      for (int teerlingNummer = 0; teerlingNummer < _model.AantalTeerlingen; teerlingNummer++)
      {
        // Maak een nieuwe teerling aan
        TeerlingController teerling = new TeerlingController(this);
        teerling._model.Vast = false;
        // Voeg de teerling toe aan het model
        _model.addTeerling(teerling);
        teerling.getView().updateUI(); //updat view 
      }
    }

    public void smijtAlleTeerlingen()
    {
      List<TeerlingController> teerlingen = _model.Teerlingen; //krijg model voor alle teerlingen

      foreach (TeerlingController teerling in teerlingen)
      {
        //werp teerlingen
        teerling.werpTeerling();
        // update view teerlingen
        teerling.getView().updateUI();
      }
    }
  }
}