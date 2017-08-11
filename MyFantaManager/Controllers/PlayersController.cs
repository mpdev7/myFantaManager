using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using MyFantaManager.Models;
using MyFantaManager.Models.Commons;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFantaManager.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        public static PlayerContainer players = new PlayerContainer();

        private FantaDbContext _dbcontext;

        public PlayersController(FantaDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        [HttpGet]
        [Route("GetAllPlayers")]
        public JsonResult GetAllPlayers()
        {


            GetPlayerJson();

            var playersDb = _dbcontext.Players.FirstOrDefault();


            return Json(players.Data);
        }

        [HttpGet]
        [Route("GetPlayerByName")]
        public JsonResult GetPlayerByName(string playerName = "", string roleName = "", string teamName = "")
        {
            playerName = playerName != null ? playerName.ToLower() : "";
            roleName = roleName != null ? roleName.ToLower() : "";
            teamName = teamName != null ? teamName.ToLower() : "";

            //var htmlToPlayers = GetHtmlTableFromClassAndUrl(Constants.TableClassName, Constants.DownloadAllPlayers);

            return Json(players.Data.Where(p => p.Nominativo.ToLower().Contains(playerName) && p.Ruolo.ToLower().Contains(roleName) && p.Squadra.ToLower().Contains(teamName)).OrderByDescending(x => x.Ruolo));
        }


        #region private Method

        private static void GetPlayerJson()
        {
            var json = System.IO.File.ReadAllText("wwwroot/assets/Rose2017.json");

            var jsonToPlayers = JsonConvert.DeserializeObject<PlayerContainer>(json);

            players = jsonToPlayers;
        }

        #endregion
    }
}
