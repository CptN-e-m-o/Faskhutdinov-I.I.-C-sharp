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
        public void AddAirfield(string name)
        {
            if (airfieldStages.ContainsKey(name))
            {
                return;
            }
            airfieldStages.Add(name, new AirField<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление аэродрома
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
        public void SaveData(string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter
            (filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("AirfieldCollection");
                foreach (KeyValuePair<string, AirField<Vehicle>> level in airfieldStages)
                {
                    streamWriter.WriteLine("Airfield" + separator + level.Key);
                    foreach (ITransport vehicle in level.Value)
                    {
                        if (vehicle.GetType().Name == "Plane")
                        {
                            streamWriter.Write("Plane" + separator);
                        }
                        else if (vehicle.GetType().Name == "Hydroplane")
                        {
                            streamWriter.Write("Hydroplane" + separator);
                        }
                        streamWriter.WriteLine(vehicle);
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("AirfieldCollection"))
            {
                //очищаем записи
                airfieldStages.Clear();
            }
            else
            {
                //если нет такой записи, то это не те данные
                throw new Exception("Неверный формат файла");
            }
            Vehicle plane = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i].Contains("Airfield"))
                {
                    //начинаем новый аэродром
                    key = strs[i].Split(separator)[1];
                    airfieldStages.Add(key, new AirField<Vehicle>(pictureWidth,
                    pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "Plane")
                {
                    plane = new Plane(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "Hydroplane")
                {
                    plane = new Hydroplane(strs[i].Split(separator)[1]);
                }
                if (!(airfieldStages[key] + plane))
                {
                    throw new Exception("Не удалось загрузить автомобиль на парковку");
                }
            }

        }
    }
}