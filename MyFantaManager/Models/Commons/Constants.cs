using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFantaManager.Models.Commons
{
    public static class Constants
    {
        public static string DownloadAllPlayers = "http://www.fantacalcio.kataweb.it/stat/index.php?page=calciatori&ruolo=all";
        public static string DownloadForwardPlayers = "http://www.fantacalcio.kataweb.it/stat/index.php?page=calciatori&ruolo=A";
        public static string DownloadMidfielderPlayers = "http://www.fantacalcio.kataweb.it/stat/index.php?page=calciatori&ruolo=C";
        public static string DownloadDefenderPlayers = "http://www.fantacalcio.kataweb.it/stat/index.php?page=calciatori&ruolo=D";
        public static string DownloadGoalkeeperPlayers = "http://www.fantacalcio.kataweb.it/stat/index.php?page=calciatori&ruolo=P";

        public static string TableClassName = "table expanded tablesorter";
    }
}
