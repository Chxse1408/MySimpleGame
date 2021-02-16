using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using MySimpleGame.Models;

namespace MySimpleGame.Data
{
    public class DataServiceXml : IDataService
    {
        private string _dataFilePath;

        public List<Player> ReadAll()
        {
            List<Player> players = new List<Player>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>), new XmlRootAttribute("Players"));

            try
            {
                StreamReader reader = new StreamReader(_dataFilePath);
                using (reader)
                {
                    players = (List<Player>)serializer.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return players;
        }

        public void WriteAll(List<Player> players)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>), new XmlRootAttribute("Players"));

            try
            {
                StreamWriter writer = new StreamWriter(_dataFilePath);
                using (writer)
                {
                    serializer.Serialize(writer, players);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataServiceXml()
        {
            _dataFilePath = @"Data\Data.xml";
        }
    }
}