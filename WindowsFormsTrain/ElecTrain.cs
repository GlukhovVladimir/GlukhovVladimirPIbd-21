using System;
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
        private const int carWidth = 100;
        private const int carHeight = 60;
        public Color DopColor { private set; get; }
        public bool Antenna { private set; get; }
        public bool Headlamp { private set; get; }
   
        public ElecTrain(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool antenna, bool headlamp) : base(maxSpeed, weight, mainColor)
        bool antenna, bool headlamp) : base(maxSpeed, weight, mainColor, dopColor)
    class ElecTrain
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int carWidth = 100;
        private const int carHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Antenna { private set; get; }
        public bool Headlamp { private set; get; }
        
        public ElecTrain(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool antenna, bool headlamp)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Antenna = antenna;
            Headlamp = headlamp;
        }   
  
        public override void DrawCar(Graphics g)
        {
            Pen romb = new Pen(DopColor);
            Brush headlamp = new SolidBrush(Color.Yellow);
            base.DrawCar(g);
            Pen romb = new Pen(Color.Black);
            Brush headlamp = new SolidBrush(Color.Yellow);
            base.DrawCar(g);
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - 2.1 * carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > -0.01 * carWidth)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 1.4 * carHeight)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - 0.2 * carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush spoiler = new SolidBrush(DopColor);
            Brush body = new SolidBrush(MainColor);
            Pen romb = new Pen(DopColor);
            Brush wheels = new SolidBrush(Color.Black);
            Brush empty = new SolidBrush(Color.White);
            Brush headlamp = new SolidBrush(Color.Yellow);

            g.FillRectangle(body, _startPosX, _startPosY - 50, 100, 50);
            g.FillRectangle(body, _startPosX + 110, _startPosY - 50, 100, 50);
            g.FillRectangle(empty, _startPosX + 25, _startPosY - 15, 50, 15);
            g.FillRectangle(empty, _startPosX + 135, _startPosY - 15, 50, 15);
            g.FillEllipse(wheels, _startPosX + 28, _startPosY - 10, 20, 20);
            g.FillEllipse(wheels, _startPosX + 52, _startPosY - 10, 20, 20);
            g.FillEllipse(wheels, _startPosX + 138, _startPosY - 10, 20, 20);
            g.FillEllipse(wheels, _startPosX + 162, _startPosY - 10, 20, 20);
            g.FillRectangle(empty, _startPosX + 15, _startPosY - 40, 30, 20);
            g.FillRectangle(empty, _startPosX + 55, _startPosY - 40, 30, 20);
            g.FillRectangle(empty, _startPosX + 125, _startPosY - 40, 30, 20);
            g.FillRectangle(empty, _startPosX + 175, _startPosY - 40, 32, 20);
            if (Antenna)
            {
                g.DrawLine(romb, _startPosX + 15, _startPosY - 70, _startPosX + 50, _startPosY - 85);
                g.DrawLine(romb, _startPosX + 50, _startPosY - 85, _startPosX + 85, _startPosY - 70);
                g.DrawLine(romb, _startPosX + 85, _startPosY - 70, _startPosX + 50, _startPosY - 55);
                g.DrawLine(romb, _startPosX + 50, _startPosY - 55, _startPosX + 15, _startPosY - 70);
                g.DrawLine(romb, _startPosX + 125, _startPosY - 70, _startPosX + 160, _startPosY - 85);
                g.DrawLine(romb, _startPosX + 160, _startPosY - 85, _startPosX + 195, _startPosY - 70);
                g.DrawLine(romb, _startPosX + 195, _startPosY - 70, _startPosX + 160, _startPosY - 55);
                g.DrawLine(romb, _startPosX + 160, _startPosY - 55, _startPosX + 125, _startPosY - 70);
            }
            if (Headlamp)
            {
                g.FillRectangle(headlamp, _startPosX + 200, _startPosY - 20, 10, 10);
            }
        }
        public void setDopColor(Color color)
        {
            DopColor = color;
        }
    }
}


