using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrain
{
    public class TrainVehicle : Vehicle
    {
        private const int carWidth = 100;
        private const int carHeight = 60;
        public TrainVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public override void MoveTransport(Direction direction)
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
  
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);    
            Brush body = new SolidBrush(MainColor);
            Brush wheels = new SolidBrush(Color.Black);
            Brush empty = new SolidBrush(Color.White);
            g.FillRectangle(body, _startPosX, _startPosY - 50 + 60 + 40, 100, 50);
            g.FillRectangle(body, _startPosX + 110, _startPosY - 50 + 60 + 40, 100, 50);
            g.FillRectangle(empty, _startPosX + 25, _startPosY - 15 + 60 + 40, 50, 15);
            g.FillRectangle(empty, _startPosX + 135, _startPosY - 15 + 60 + 40, 50, 15);
            g.FillEllipse(wheels, _startPosX + 28, _startPosY - 10 + 60 + 40, 20, 20);
            g.FillEllipse(wheels, _startPosX + 52, _startPosY - 10 + 60 + 40, 20, 20);
            g.FillEllipse(wheels, _startPosX + 138, _startPosY - 10 + 60 + 40, 20, 20);
            g.FillEllipse(wheels, _startPosX + 162, _startPosY - 10 + 60 + 40, 20, 20);
            g.FillRectangle(empty, _startPosX + 15, _startPosY - 40 + 60 + 40, 30, 20);
            g.FillRectangle(empty, _startPosX + 55, _startPosY - 40 + 60 + 40, 30, 20);
            g.FillRectangle(empty, _startPosX + 125, _startPosY - 40 + 60 + 40, 30, 20);
            g.FillRectangle(empty, _startPosX + 175, _startPosY - 40 + 60 + 40, 32, 20);
        }
    }
}
