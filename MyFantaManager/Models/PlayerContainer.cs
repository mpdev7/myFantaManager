using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFantaManager.Models
{
    public class PlayerContainer
    {
        [Key]
        public int PlayersDataId { get; set; }

        public List<Player> Data { get; set; }
    }
}
