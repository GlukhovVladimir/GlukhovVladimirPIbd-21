using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrain
{
    public partial class FormTrain : Form
    {
        private ITransport train;
        public FormTrain()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrain.Width, pictureBoxTrain.Height);
            Graphics gr = Graphics.FromImage(bmp);
            train.DrawTrain(gr);
            pictureBoxTrain.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            train = new TrainVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            train.SetPosition(100, 100, pictureBoxTrain.Width,
            pictureBoxTrain.Height);
            Draw();
        }
       
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    train.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    train.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    train.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    train.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        private void buttonCreateElecTrain_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            train = new ElecTrain(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true);
            train.SetPosition(rnd.Next(100, 100), rnd.Next(100, 100), pictureBoxTrain.Width,
            pictureBoxTrain.Height);
            Draw();
        }
    }
}