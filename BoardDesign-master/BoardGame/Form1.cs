using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                     //DRAGOVER

namespace BoardGame
{
    public partial class Form1 : Form
    {

        Color backgroundTile = Color.Black;
        Color backgroundForm = Color.White;

        //height and width of tiles
        int hTile;
        int wTile;

        //number of tiles
        int numTiles = 0;
        List<Panel> tilesCreated = new List<Panel>();

        //starting position of first tile
        Point position = new Point(0, 0);

        //coordinates for each arrow- changes with each arrow click- should always be 0 or hTile/wTile
        Point testMove = new Point(0, 0);
        Point temp = new Point(0, 0);

        Point startPoint = new Point(0, 0);

        //dimentions of form1
        int hForm;
        int wForm;

        int direction = 0;  //used to verify that the direction has been set

        //bool value to determine if an arrow has been already clicked
        //prevents island tiles and extra clicking
        bool arrowClicked = false;
        bool placeClicked = false;  //bool value to prevent double clicking the place button and overlapping tiles
        //bool isDrag = false;

        bool tileClicked;
        bool ctrlPressed;
        List<Panel> ctrlClicked = new List<Panel>();
        List<Panel> ctrlHighlight= new List<Panel>();

        string imagePath;
        bool imageAdded;

        Form addImage = new Form();
        TextBox tbBrowse = new TextBox();
        Button btnImageOK = new Button();

        Panel highlight = new Panel();
        Panel clickedTile = new Panel();



        public Form1()
        {
            InitializeComponent();
            //pbBackground.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            tileClicked = false;
            ctrlPressed = false;
            ctrlClicked.Clear();
            highlight.Visible = false;
        }

        //determines the sizes of the form and tile and sets initial tile start postition
        private void btnCreate_Click(object sender, EventArgs e)
        {
            gbInitialInfo.Visible = false;
            gbToolbox.Enabled = true; //hides toolbar

            //checks form size text boxes, if empty or has !digits it sets to default 600x600
            if ((string.IsNullOrEmpty(tbFormHeight.Text) == true) || (Int32.TryParse(tbFormHeight.Text, out hForm) == false)) // || string.IsNullOrEmpty(tbWidth.Text))
            {
                hForm = 600;
            }
            if ((string.IsNullOrEmpty(tbFormWidth.Text) == true) || (Int32.TryParse(tbFormWidth.Text, out wForm) == false)) // || string.IsNullOrEmpty(tbWidth.Text))
            {
                wForm = 600;
            }
            this.Size = new Size(wForm, hForm);

            //checks tile size text boxes, if empty or has !digits it sets to default 30x30
            if ((string.IsNullOrEmpty(tbTileHeight.Text) == true) || (Int32.TryParse(tbTileHeight.Text, out hTile) == false)) // || string.IsNullOrEmpty(tbWidth.Text))
            {
                hTile = 30;
            }
            if ((string.IsNullOrEmpty(tbFormWidth.Text) == true) || (Int32.TryParse(tbFormWidth.Text, out wTile) == false)) // || string.IsNullOrEmpty(tbWidth.Text))
            {
                wTile = 30;
            }

            //checks tile start position text boxes, if empty or has !digits it sets to default 300x400
            if ((string.IsNullOrEmpty(tbTileHeight.Text) == true) || (Int32.TryParse(tbTileHeight.Text, out hTile) == false)) // || string.IsNullOrEmpty(tbWidth.Text))
            {
                //y = 200;
                position.Y = 200;
            }
            if ((string.IsNullOrEmpty(tbFormWidth.Text) == true) || (Int32.TryParse(tbFormWidth.Text, out wTile) == false)) // || string.IsNullOrEmpty(tbWidth.Text))
            {
                //x = 300;
                position.X = 300;
            }

        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            //prevents creating overlapping tiles at start
            if (numTiles == 1 && arrowClicked == false)
            {
                return;
            }

            //checks if next tile will be out of the form, if yes then cancel creating new tile
            if (Boundary() == false)
            {
                return;
            }

            {
                numTiles++;                                 //increments number of tiles

                CreateTile();

                arrowClicked = false;
                placeClicked = true;
            }
            highlight.Visible = false;
        }

        //determines if the next tile will exit the form
        private bool Boundary()
        {
            temp.X = position.X; //if hits a boundary/ can't move this restores point to head tile
            temp.Y = position.Y;

            VerifiedDirection();    //moves position of head tile

            if (position.X < 3 || position.X > (this.Width - 45)) //if outside the form
            {
                position.X = temp.X;    //reset the position to current tile
                position.Y = temp.Y;    //shouldnt need this but just in case -  full reset
                return false;
            }
            else if (position.Y < (gbToolbox.Height + 3) || position.Y > (this.Height - 75))
            {
                position.X = temp.X;    //shouldnt need this but just in case -  full reset
                position.Y = temp.Y;    //reset the position to current tile
                return false;
            }
            else
            {
                return true;    //if next tile is in form return that it can move
            }
        }

        public void VerifiedDirection() //after the place button this sets the position of the head tile
        {
            if (direction == 1200)  //up
            {
                //y -= hTile +1;
                position.Y -= hTile + 1;
            }
            else if (direction == 6000) //down
            {
                //y += hTile +1;
                position.Y += hTile + 1;
            }
            else if (direction == 3000) //right
            {
                //x += wTile +1;
                position.X += wTile + 1;
            }
            else if (direction == 9000) //left
            {
                //x -= wTile +1;
                position.X -= wTile + 1;
            }
        }

        public void CreateTile()
        {
      
            Panel tile = new Panel(); //creates new tile panel

            if (imageAdded == true)
            {
                tile.BackgroundImage = Image.FromFile(imagePath); //get tile from panel selected
                tile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else
            {
                tile.BackColor = backgroundTile;               //fills tile with color
                imageAdded = false;
            }
            //tile.BorderStyle = BorderStyle.FixedSingle;               
            tile.Size = new Size(wTile, hTile); //sets size of tile             
                                                //tile.Location = new Point(x, y);            //sets location of tile
            tile.Location = new Point(position.X, position.Y);

            tile.Name = "tile" + numTiles;              //changes name of tile to "tile#"
            tile.MouseClick += Panel_Click;             //creates event for tile / addes mouseClick event


                foreach (Panel p in tilesCreated) //checks if tile is overlapping another tile
                {
                    if (tile.Bounds.IntersectsWith(p.Bounds))
                    {
                    tile.BackColor = Color.Yellow; //tile changes color to yellow
                    }
                }

            tilesCreated.Add(tile);//adds panel to list of tiles already created
            Controls.Add(tile); //adds panel to the form
            tile.BringToFront(); //

            pbBackground.SendToBack(); //prevents the BG panel from covering the new highlight panel
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            clickedTile = (Panel)sender;
            tileClicked = true;
            highlight.Visible = true;

            highlight.BackColor = Color.Red;
            //sets size of tile
            highlight.Size = new Size(wTile + 2, hTile + 2);
            //sets location of tile
            highlight.Location = new Point(clickedTile.Location.X - 1, clickedTile.Location.Y - 1);
            Controls.Add(highlight);
            pbBackground.SendToBack();

            if (ModifierKeys.HasFlag(Keys.Control)) //if ctrl has been pressed
            {
                 if (ModifierKeys.HasFlag(Keys.Control)) //if ctrl has been pressed
            { //create and add new highlights to list
                Panel temp = new Panel();
                temp.BackColor = Color.Red;
                //sets size of tile
                temp.Size = new Size(wTile + 2, hTile + 2);
                //sets location of tile
                temp.Location = new Point(clickedTile.Location.X - 1, clickedTile.Location.Y - 1);
                Controls.Add(temp);
                ctrlHighlight.Add(temp);
                ctrlPressed = true;
                ctrlClicked.Add(clickedTile);
                return;
            }
            }
            else
              {
                clearList();
                ctrlClicked.Clear(); //clears the ctrl list
            }
            clearList();
            ctrlPressed = false;
            position.X = clickedTile.Location.X; //allows branching from other tiles 
            position.Y = clickedTile.Location.Y; //instead of one snake
        }
         public void clearList()
        { //delete a list of panels
            foreach (Panel p in ctrlHighlight)
            {
                Controls.Remove(p);
                p.Dispose();
            }
            ctrlHighlight.Clear();

        }

        private void btnDelete_Click(object sender,EventArgs e)
        {
            Controls.Remove(clickedTile);
            clickedTile.Dispose();

            foreach(Panel p in ctrlClicked)
            {
                Controls.Remove(p);
                p.Dispose();
           }
         }
        
        private void btnDeleteTile_Click(object sender, EventArgs e)
        { //delete a tile
            Controls.Remove(clickedTile);

            foreach (Panel p in ctrlHighlight)
            {
                Controls.Remove(p);
            }
            foreach (Panel p in ctrlClicked)
            {
                Controls.Remove(p);
                tilesCreated.Remove(p);
            }

            highlight.Visible = false;
            tilesCreated.Remove(clickedTile);

            clickedTile.Dispose();
        }


        private void btnArrows_Click(object sender, EventArgs e)
        {
            Button btnDirection = (Button)sender;   //reads which arrow button was clicked

            if (placeClicked == false && arrowClicked == true) //if a second arrow has been click but has not been placed
            {
                //arrowX = 0;             //resets the arrow button
                //arrowY = 0;
                testMove.X = 0;
                testMove.Y = 0;
                arrowClicked = false;
            }
            //checks if a tile has been placed. prevents moving multiple squares and creating an island tile
            if (arrowClicked == false)   //if an arrow has been clicked
            {
                if (btnDirection == btnUp)   //if the clicked button was up
                {
                    direction = 1200;             //move the starting point of the next tile up the distance of the tile
                                                  //arrowX = 0;             //coordinates of up = same column (X), different row (Y)
                                                  //arrowY = -hTile;
                    testMove.X = position.X;
                    testMove.Y = position.Y - hTile;

                }
                else if (btnDirection == btnDown) //if the clicked button was down
                {
                    direction = 6000;
                    //arrowX = 0;             //coordinates of down = same column (X), different row (Y)
                    //arrowY = hTile;
                    testMove.X = position.X;
                    testMove.Y = position.Y + hTile;
                }
                else if (btnDirection == btnLeft) //if the clicked button was left
                {
                    direction = 9000;
                    //arrowX = -wTile;        //coordinates of left = differnt column (X), same row (Y)
                    //arrowY = 0;
                    testMove.X = position.X - wTile;
                    testMove.Y = position.Y;
                }
                else if (btnDirection == btnRight) //if the clicked button was right
                {
                    direction = 3000;
                    //arrowX = wTile;          //coordinates of left = differnt column (X), same row (Y)
                    //arrowY = 0;
                    testMove.X = position.X + wTile;
                    testMove.Y = position.Y;
                }

            }

            arrowClicked = true;
            placeClicked = false;
        }

        private void btnColorDialog_Click(object sender, EventArgs e) //opens a color dialog to change color of tile
        {
            Button btn = (Button)sender; //sets button clicked to temp 'btn'
            ColorDialog colorDialogBox = new ColorDialog(); //pop up color dialog

            if (colorDialogBox.ShowDialog() == DialogResult.OK) //after a color has been chosen and OK clicked
            {
                if (btn == btnColorBG)  //if the background color button has been clicked
                {
                    this.BackColor = colorDialogBox.Color;   //changes color of background
                    pbBackground.BackgroundImage = null;
                }
                else if (btn == btnColorTile)   //if the tile color button has been clicked
                {
                    if (tileClicked == true)
                    {
                        if (ctrlPressed == true) //for multiple selections
                        {
                            foreach (Panel p in ctrlClicked)
                            {
                                p.BackColor = colorDialogBox.Color; //get tile from panels selected
                                p.BackgroundImage = null;
                                imageAdded = false;
                            }
                        }
                        else
                        {
                            clickedTile.BackColor = colorDialogBox.Color; //get tile from panel selected
                            clickedTile.BackgroundImage = null;
                            imageAdded = false;
                        }
                    }
                    else //if a tile has NOT been selected
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Panel)
                            {
                                c.BackColor = colorDialogBox.Color;
                                c.BackgroundImage = null;
                            }
                        }
                        backgroundTile = colorDialogBox.Color;
                    }

                }
            }
        }
        private void btnImage_Click(object sender, EventArgs e) //checks if the browse button has been clicked for image
        {
            imagePath = GetImage();
            if (imagePath == null)
            {
                return;
            }

            Button btn = (Button)sender; //sets button clicked to temp 'btn'


            if (btn == btnImageBG)  //if the background color button has been clicked
            {
                pbBackground.BackgroundImage = Image.FromFile(imagePath);
                pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (btn == btnImageTile)   //if the tile color button has been clicked
            {

                if (tileClicked == true) //only if a tile has been selected
                {
                    if (ctrlPressed == true) //for multiple selections
                    {
                        foreach (Panel p in ctrlClicked)
                        {
                            imageAdded = true;
                            p.BackgroundImage = Image.FromFile(imagePath); //get tile from panel selected
                            p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        }
                    }
                    else
                    {
                        imageAdded = true;
                        clickedTile.BackgroundImage = Image.FromFile(imagePath); //get tile from panel selected
                        clickedTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                }
                else //changes every tile on the board
                {
                    foreach (Control c in Controls)
                    {
                        if (c is Panel)
                        {
                            c.BackgroundImage = Image.FromFile(imagePath);
                            c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            //tile.BackColor = System.Drawing.Color.Transparent;

                        }

                    }
                }
            }

        }

        public string GetImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); //creates fileDialog

            fileDialog.InitialDirectory = @"C:\Pictures"; //& RestoreDir
            fileDialog.Title = "Browse";    //btn text?

            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;

            fileDialog.DefaultExt = "png";
            fileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            else if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return null;
            }
            else
            {
                return null;
            }
        }
        
        
        private void cbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reads which shape was selected
            int selection = cbShapes.SelectedIndex;

            if (selection == 0) //if selection is 'Circle'
            {
                drawCircle();
            }
            else if (selection == 1)//if selection is 'Triangle'
            {
                drawTriangle();
            }
            else
            {
                return;
            }

        }

        public void drawCircle()
         {
             System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();

             //set a new rectangle to the same size as the button's ClientRectange property
             System.Drawing.Rectangle newPanel = clickedTile.ClientRectangle;

             //create a circle withing the new rectangle
             buttonPath.AddEllipse(newPanel);

             //set the buttons region property to the newly created circle region
             clickedTile.Region = new System.Drawing.Region(buttonPath);
             clickedTile.BackColor = backgroundTile;
         }

        public void drawTriangle()
        {
            // Triangle button
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();

            //set a new rectangle to the same size as the button's ClientRectange property
            System.Drawing.Rectangle newPanel = clickedTile.ClientRectangle;

            Point[] points = {

        new Point(clickedTile.Width / 2, 0),

        new Point(0, clickedTile.Height),

        new Point(clickedTile.Width, clickedTile.Height) };

            buttonPath.AddPolygon(points);
            clickedTile.Region = new System.Drawing.Region(buttonPath);
            clickedTile.BackColor = backgroundTile;
        }

        private void pbBackground_Click(object sender, EventArgs e)
        {
            tileClicked = false;
            ctrlPressed = false;
            ctrlClicked.Clear();
            highlight.Visible = false;
        }
    }
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
