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
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(15, pictureBoxParking.Width,pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetLocomotive_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new TrainVehicle(100, 1000, dialog.Color);
                int place = parking + car;
                Draw();
            }
        }

        private void buttonTakeTrain_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                   pictureBoxTakeTrain.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 100, pictureBoxTakeTrain.Width,
                   pictureBoxTakeTrain.Height);
                    car.DrawCar(gr);
                    pictureBoxTakeTrain.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width,
                   pictureBoxTakeTrain.Height);
                    pictureBoxTakeTrain.Image = bmp;
                }
                Draw();
            }
        }

        private void buttonSetElecTrain_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new ElecTrain(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    int place = parking + car;
                    Draw();
                }
            }
        }
    }
}
