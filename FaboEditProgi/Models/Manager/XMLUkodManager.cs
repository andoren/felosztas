using FaboEditProgi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Caliburn.Micro;
using System.Configuration;
using System.Xml.Serialization;
using System.Linq;

namespace FaboEditProgi.Models.Manager
{
    class XMLUkodManager:IUkodManager
    {
        StreamReader reader;
        StreamWriter writer;

        string defaultPath;
        public XMLUkodManager()
        {
            Init();
        }
        private void Init()
        {
            defaultPath = Directory.GetCurrentDirectory() + "\\Data\\ukodok.xml";
            if (!File.Exists(defaultPath))
            {
                File.Create(defaultPath).Close();
                WriteXml(new BindableCollection<UkodModel>());
            }
          

        }
        public bool AddUkod(UkodModel ukod)
        {
            bool success = true;
            try
            {
                
                BindableCollection<UkodModel> adatok = GetAllUkod();
                int id = 0;
                try
                {
                    id = adatok.Max(x => x.Id);
                }
                catch (Exception) { 
                    
                }
                ukod.Id = id + 1;
                adatok.Add(ukod);
                WriteXml(adatok);
            }
            catch (Exception e) {
                success = false;
            }
            return success;

        }

        public bool DeleteUkodById(int id)
        {
            BindableCollection<UkodModel> adatok = GetAllUkod();
            UkodModel model = adatok.Where(x => x.Id == id).First();
            bool success =  adatok.Remove(model);
            WriteXml(adatok);
            return success;
        }

        public BindableCollection<UkodModel> GetAllUkod()
        {
          BindableCollection<UkodModel> ukodok = new BindableCollection<UkodModel>();
          XmlSerializer x = new XmlSerializer(ukodok.GetType());
            try
            {
                using (StreamReader textReader = new StreamReader(defaultPath, Encoding.UTF8))
                {
                    ukodok = (BindableCollection<UkodModel>)x.Deserialize(textReader);
                }
            }
            catch (Exception e) {
                return ukodok;
            }
          return ukodok;
        }

        public UkodModel GetUkodById(int id)
        {
            BindableCollection<UkodModel> adatok = GetAllUkod();
            UkodModel model = adatok.Where(x => x.Id == id).FirstOrDefault();
            return model;
        }

        public bool ModifyUkod(UkodModel ukod)
        {
            bool success = true;
            BindableCollection<UkodModel> adatok = GetAllUkod();
            if (adatok.Remove(adatok.Where(x => x.Id == ukod.Id).FirstOrDefault()))
            {
                adatok.Add(ukod);
                WriteXml(adatok);
            }
            else success = false;
            return success;
        }
        private void WriteXml(BindableCollection<UkodModel> adatok) {
            XmlSerializer x = new XmlSerializer(adatok.GetType());
            using (StreamWriter writer = new StreamWriter(defaultPath))
            {
                x.Serialize(writer, adatok);
                writer.Flush();
                writer.Close();
            }
        }
    }
}
