using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace WindowsFormsTrain
{
    public class Parking<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Parking<T>>
        where T : class, ITransport
    {
        private Dictionary<int, T> _places;
        private int _maxCount;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int _placeSizeWidth = 300;
        private const int _placeSizeHeight = 130;
        private int _currentIndex;

        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }

        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            _currentIndex = -1;
        }

        public static int operator +(Parking<T> p, T train)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.ContainsValue(train))
            {
                throw new ParkingAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, train);
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T train = p._places[index];
                p._places.Remove(index);
                return train;
            }
            throw new ParkingNotFoundException(index);
        }

        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawTrain(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
           
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 720);
            for (int i = 0; i < _maxCount / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 500, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 650);
            }
        }

        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new ParkingNotFoundException(ind);

            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5
                    * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new ParkingOccupiedPlaceException(ind);
                }

            }

        }
        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            _places.Clear();
        }

        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Parking<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is TrainVehicle && other._places[thisKeys[i]] is ElecTrain)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is ElecTrain && other._places[thisKeys[i]] is TrainVehicle)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is TrainVehicle && other._places[thisKeys[i]] is TrainVehicle)
                    {
                        return (_places[thisKeys[i]] is
                       TrainVehicle).CompareTo(other._places[thisKeys[i]] is TrainVehicle);
                    }
                    if (_places[thisKeys[i]] is ElecTrain && other._places[thisKeys[i]]
                    is ElecTrain)
                    {
                        return (_places[thisKeys[i]] is
                       ElecTrain).CompareTo(other._places[thisKeys[i]] is ElecTrain);
                    }
                }
            }
            return 0;
        }
    }
}
