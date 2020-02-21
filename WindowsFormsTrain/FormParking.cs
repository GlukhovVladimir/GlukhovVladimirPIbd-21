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
        MultiLevelParking parking;
        private const int countLevel = 5;
        FormTrainConfig trainForm;

        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
            pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width,
            pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonSetLocomotive_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var train = new TrainVehicle(100, 1000, dialog.Color);
                    int place = parking[listBoxLevels.SelectedIndex] + train;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void buttonTakeTrain_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    var train = parking[listBoxLevels.SelectedIndex] -  Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (train != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                       pictureBoxTakeTrain.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        train.SetPosition(5, 100, pictureBoxTakeTrain.Width,
                       pictureBoxTakeTrain.Height);
                        train.DrawTrain(gr);
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
        }

        private void buttonSetElecTrain_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new ElecTrain(100, 1000, dialog.Color, dialogDop.Color,
                       true, true);
                        int place = parking[listBoxLevels.SelectedIndex] + train;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }

        }

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
       
        private void AddTrain(ITransport train)
        {
            if (train != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + train;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
        private void buttonFormTrainConfig_Click(object sender, EventArgs e)
        {
            trainForm = new FormTrainConfig();
            trainForm.AddEvent(AddTrain);
            trainForm.Show();
        }
    }
}
