using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

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
                        var vehicle = level[i];
                        if (vehicle != null)
                        {
                            if (vehicle.GetType().Name == "Locomotive")
                            {
                                sw.Write(i + ":Locomotive:");
                            }
                            if (vehicle.GetType().Name == "ElecTrain")
                            {
                                sw.Write(i + ":ElecTrain:");
                            }
                            sw.WriteLine(vehicle);
                        }
                    }
                }
                return true;
            }
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string buff = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buff = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buff.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITransport vehicle = null;
                while ((buff = sr.ReadLine()) != null)
                {
                    if (buff == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buff))
                    {
                        continue;
                    }
                    if (buff.Split(':')[1] == "Truck")
                    {
                        vehicle = new TrainVehicle(buff.Split(':')[2]);
                    }
                    else if (buff.Split(':')[1] == "Tipper")
                    {
                        vehicle = new ElecTrain(buff.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buff.Split(':')[0])] = vehicle;
                }
            }
            return true;
        }

        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}
