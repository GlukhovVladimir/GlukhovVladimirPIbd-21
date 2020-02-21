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
    public partial class FormTrainConfig : Form
    {
        ITransport train = null;
        private event trainDelegate eventAddTrain;
        public FormTrainConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawTrain()
        {
            if (train != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTrainConfig.Width, pictureBoxTrainConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(5, 5, pictureBoxTrainConfig.Width, pictureBoxTrainConfig.Height);
                train.DrawTrain(gr);
                pictureBoxTrainConfig.Image = bmp;
            }
        }

        public void AddEvent(trainDelegate ev)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain = new trainDelegate(ev);
            }
            else
            {
                eventAddTrain += ev;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                if (train is ElecTrain)
                {
                    (train as
                   ElecTrain).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTrain();
                }
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                train.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTrain();
            }
        }

        private void labelTrain_MouseDown(object sender, MouseEventArgs e)
        {
            labelLocomotive.DoDragDrop(labelLocomotive.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelElecTrain_MouseDown(object sender, MouseEventArgs e)
        {
            labelElecTrain.DoDragDrop(labelElecTrain.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        private void panelTrain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelTrain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Locomotive":
                    train = new TrainVehicle(100, 500, Color.White);
                    break;
                case "ElecTrain":
                    train = new ElecTrain(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawTrain();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);
            Close();
        }
    }
}
