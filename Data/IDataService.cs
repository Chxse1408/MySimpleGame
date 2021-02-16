using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySimpleGame.Models;

namespace MySimpleGame.Data
{
    public interface IDataService
    {
        List<Player> ReadAll();

        void WriteAll(List<Player> players);
    }
}