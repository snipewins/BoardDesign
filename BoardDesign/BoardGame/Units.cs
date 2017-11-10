using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class Form1 : Form
    {
        //colin's code
        public class Panel1 : Panel //this class allows each panel to have a list of the connected panels
        {
            public LinkedList<Panel1> connectedList;


        }
        public class Unit
        {
            private Panel1 currentLocation;//square's current location
            private PictureBox unitsPicture;
            public Unit(Panel1 startingLocation)//instantiate a Unit
            {
                //on creation, the starting location will be the one that is currently highlighted


                //graphic representaion
                this.unitsPicture = new PictureBox();
                unitsPicture.BringToFront();
                unitsPicture.BackColor = System.Drawing.Color.LimeGreen;
                unitsPicture.Size = new System.Drawing.Size(startingLocation.Width - 4, startingLocation.Height - 4); //sets size of tile             
                                                                                                                      //tile.Location = new Point(x, y);            //sets location of tile
                unitsPicture.Location = new Point(startingLocation.Location.X, startingLocation.Location.Y);
                this.adjustLocation();

                //variable to hold locationID
                this.currentLocation = startingLocation;
            }
            public Panel1 getLocation(Unit thisUnit)
            {
                return thisUnit.currentLocation;
            }

            public void changeLocation(Panel1 newLocation)
            {
                this.currentLocation = newLocation; this.changeLocation(newLocation);//
                this.unitsPicture.Location = newLocation.Location;
                this.adjustLocation();
            }

            public void adjustLocation()
            {
                this.unitsPicture.Location = new Point(unitsPicture.Location.X - 2, unitsPicture.Location.Y - 2);
            }
        }







    }
}
