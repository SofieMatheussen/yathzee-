using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YathzeeTeerling
{
  public partial class YahtzeeView : UserControl
  {
    private YahtzeeController _controller;

    public YahtzeeView(YahtzeeController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void YahtzeeView_Load(object sender, EventArgs e)
    {
     // Maak een lijst aan waarin de teerlingen worden opgevangen
      List<TeerlingView> teerlingen = _controller.getTeerlingenView(); //Lijst met alle views
      int teerlingWidth = teerlingen[0].Width; //breedte van 1 teerling voor correct naast elkaar

      foreach (TeerlingView teerling in teerlingen)
      {
        TeerlingView huidigTeerling = teerling;

        int xPos = teerlingen.IndexOf(teerling) * teerlingWidth; //x positie zetten afhankelijk van index en width
        huidigTeerling.Location = new Point(xPos, 0);

        Controls.Add(huidigTeerling); //huidige teerling toevoegen aan view

        huidigTeerling.updateUI();
      }
      smijtAlleTeerlingen.Location = new Point(20, teerlingen[0].Height); //Smijt alle teerlingen onder de teerling zetten
      startOpnieuw.Location = new Point((25 + smijtAlleTeerlingen.Width), teerlingen[0].Height);

      startOpnieuw.Visible = !(_controller.getModel().AantalWorpen <= _controller.getModel().MaxAantalWorpen);

    }

    private void startOpnieuw_Click(object sender, EventArgs e)
    {
      //spel reseten
      _controller.getModel().AantalWorpen = 0;

      startOpnieuw.Visible = false;
      List<TeerlingView> teerlingen = _controller.getTeerlingenView(); //Lijst met alle views
      foreach (var teerling in teerlingen)
      {
        teerling.getController().resetTeerling();
      }
    }

        private void gooiAlleTeerlingen_Click(object sender, EventArgs e)
        {
            _controller.getModel().AantalWorpen++;
            if (_controller.getModel().AantalWorpen <= _controller.getModel().MaxAantalWorpen)
            {
                _controller.smijtAlleTeerlingen(); //controller teerling laten werpen
                if (_controller.getModel().AantalWorpen + 1 > _controller.getModel().MaxAantalWorpen)
                {
                    startOpnieuw.Visible = true;
                }
            }
        }
    }
}