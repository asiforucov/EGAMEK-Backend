using Egamek_Business.Interfaces;
using Egamek_Business.ViewModels.GameDetailViewModel;
using Egamek_Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egamek.Controllers
{
    public class GameDetailController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGameService _gameService;
        public GameDetailController(IUnitOfWork unitOfWork, IGameService gameService)
        {
            _unitOfWork = unitOfWork;
            _gameService = gameService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var dbGame = await _gameService.Get(id);
            var gameDetailVM = new GameDetailViewModel()
            {
                game = dbGame
            };
            return View(gameDetailVM);
        }
    }
}
