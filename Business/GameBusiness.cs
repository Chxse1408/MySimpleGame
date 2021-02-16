using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySimpleGame.Models;
using MySimpleGame.Data;
using MySimpleGame.Presentation;

namespace MySimpleGame.Business

{
    public class GameBusiness
    {
        public enum GameStatus
        {
            QUIT,
            QUIT_SAVE
        }

        private List<Player> _allPlayers;
        private Player _playerOne;
        private Player _PlayerTwo;

        private IDataService _dataService;

        public GameBusiness()
        {
            InitializeDataService();
            InitializeGame();
        }

        private void InitializeDataService()
        {
            _dataService = new DataServiceSeed();
        }

        private void InitializeGame()
        {
            _allPlayers = _dataService.ReadAll();

            _playerOne = _allPlayers.FirstOrDefault(p => p.Name == "Chase");
            _PlayerTwo = _allPlayers.FirstOrDefault(p => p.Name == "Corbin");
        }

        public List<Player> GetAllPlayers()
        {
            return _dataService.ReadAll();
        }

        public void SaveAllPlayers()
        {
            _dataService.WriteAll(_allPlayers);
        }

        public (Player playerOne, Player PlayerTwo) GetCurrentPlayers()
        {
            _playerOne = _allPlayers.FirstOrDefault(p => p.Name == "Chase");
            _PlayerTwo = _allPlayers.FirstOrDefault(p => p.Name == "Corbin");
            (Player playerOne, Player playerTwo) currentPlayers = (_playerOne, _PlayerTwo);

            return currentPlayers;
        }
    }
}