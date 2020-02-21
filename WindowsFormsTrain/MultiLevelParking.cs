using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrain
{
    public class MultiLevelParking
    {       
        private const int countPlaces = 15;
        private List<Parking<ITransport>> parkingStages;
        private int pictureHeight;
        private int pictureWidth;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var car = level[i];
                        if (car != null)
                        {
                            if (car.GetType().Name == "TrainVehicle")
                            {
                                sw.Write(i + ":TrainVehicle:");
                            }
                            if (car.GetType().Name == "ElecTrain")
                            {
                               sw.Write(i + ":ElecTrain:");
                            }
                            sw.WriteLine(car);
                        }
                    }
                }
                
            }
            return true;
        }
     
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                ITransport car = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "Locomotive")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        car = new TrainVehicle(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "ElecTrain")
                    {
                        car = new ElecTrain(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = car;
                }
            }
            return true;
        }
    }
}
