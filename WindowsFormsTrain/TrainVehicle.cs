using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace WindowsFormsTrain
{
    public class TrainVehicle : Vehicle, IComparable<TrainVehicle>, IEquatable<TrainVehicle>
    {
        private const int trainWidth = 100;
        private const int trainHeight = 60;

        public TrainVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;

        }

        public TrainVehicle(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {

                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - 2.1 * trainWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > -0.01 * trainWidth)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY - step > 1.4 * trainHeight)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - 0.2 * trainHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTrain(Graphics g)
        {
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

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(TrainVehicle other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(TrainVehicle other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is TrainVehicle carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}