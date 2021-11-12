using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsPlanes
{
    class AirFieldCollection
    {
        private readonly Dictionary<string, AirField<Vehicle>> airfieldStages;
        public List<string> Keys => airfieldStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public AirFieldCollection(int pictureWidth, int pictureHeight)
        {
            airfieldStages = new Dictionary<string, AirField<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }



        /// <summary>
        /// Добавление аэродрома
        /// </summary>
        /// <param name="name">Название аэродрома</param>
        public void AddParking(string name)
        {
            if (airfieldStages.ContainsKey(name))
            {
                return;
            }
            airfieldStages.Add(name, new AirField<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название аэродрома</param>
        public void DelAirfield(string name)
        {
            if (airfieldStages.ContainsKey(name))
            {
                airfieldStages.Remove(name);
            }
        }

        public void DeleteAirfieldInt(int index)
        {
            if (index > -1 && index < airfieldStages.Count)
            {
                airfieldStages.Remove(Keys[index]);
            }
        }
        /// <summary>
        /// Доступ к аэродрому
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public AirField<Vehicle> this[string ind]
        {
            get
            {
                if (airfieldStages.ContainsKey(ind))
                {
                    return airfieldStages[ind];
                }
                return null;
            }
        }



        /// <summary>
        /// Сохранение информации по самолётам на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter
            (filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("AirfieldCollection");
                foreach (var level in airfieldStages)
                {
                    streamWriter.WriteLine("AirField" + separator + level.Key);

                    ITransport plane;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane.GetType().Name == "Plane")
                        {
                            streamWriter.Write("Plane" + separator);
                        }
                        else if (plane.GetType().Name == "Hydroplane")
                        {
                            streamWriter.Write("Hydroplane" + separator);
                        }
                        streamWriter.WriteLine(plane);
                    }
                }
                return true;
            }
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader streamReader = new StreamReader
            (filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("AirfieldCollection"))
                {
                    airfieldStages.Clear();
                }
                else
                {
                    return false;
                }
                Vehicle transport = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("AirField"))
                    {
                        key = line.Split(separator)[1];
                        airfieldStages.Add(key, new AirField<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("Plane"))
                        {
                            transport = new Plane(line.Split(separator)[1]);
                        }
                        else if (line.Contains("Hydroplane"))
                        {
                            transport = new Hydroplane(line.Split(separator)[1]);
                        }
                        if (!(airfieldStages[key] + transport))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
