using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySimpleGame.Models;

namespace MySimpleGame.Data
{
    public class DataServiceSeed : IDataService
    {
        public List<Player> ReadAll()
        {
            return new List<Player>()
            {
                new Player()
                {
                    Name = "Chase",
                    Wins = 1,
                    Losses = 1,
                    Ties = 1
                },

                new Player()
                {
                    Name = "Corbin",
                    Wins = 1,
                    Losses = 1,
                    Ties = 1
                }
            };
        }

        public void WriteAll(List<Player> players)
        {
        }
    }
}