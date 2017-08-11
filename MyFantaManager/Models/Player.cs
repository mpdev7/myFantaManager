using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFantaManager.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Nominativo { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Squadra { get; set; }
        public string Ruolo { get; set; }

    }
}
