using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsTrain
{
    class ElecTrain : TrainVehicle
    {
        private const int trainWidth = 100;
        private const int trainHeight = 60;
        public Color DopColor { private set; get; }
        public bool Antenna { private set; get; }
        public bool Headlamp { private set; get; }
   
        public ElecTrain(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool antenna, bool headlamp) : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Antenna = antenna;
            Headlamp = headlamp;
        }   
  
        public override void DrawTrain(Graphics g)
        {
            Pen romb = new Pen(DopColor);
            Brush headlamp = new SolidBrush(Color.Yellow);
            base.DrawTrain(g);
            if (Antenna)
            {
                g.DrawLine(romb, _startPosX + 15, _startPosY - 70 + 100, _startPosX + 50, _startPosY - 85 + 100);
                g.DrawLine(romb, _startPosX + 50, _startPosY - 85 + 100, _startPosX + 85, _startPosY - 70 + 100);
                g.DrawLine(romb, _startPosX + 85, _startPosY - 70 + 100, _startPosX + 50, _startPosY - 55 + 100);
                g.DrawLine(romb, _startPosX + 50, _startPosY - 55 + 100, _startPosX + 15, _startPosY - 70 + 100);
                g.DrawLine(romb, _startPosX + 125, _startPosY - 70 + 100, _startPosX + 160, _startPosY - 85 + 100);
                g.DrawLine(romb, _startPosX + 160, _startPosY - 85 + 100, _startPosX + 195, _startPosY - 70 + 100);
                g.DrawLine(romb, _startPosX + 195, _startPosY - 70 + 100, _startPosX + 160, _startPosY - 55 + 100);
                g.DrawLine(romb, _startPosX + 160, _startPosY - 55 + 100, _startPosX + 125, _startPosY - 70 + 100);
            }
            if (Headlamp)
            {
                g.FillRectangle(headlamp, _startPosX + 200, _startPosY - 20 + 100, 10, 10);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

    }
}


