using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superheroes.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }

        public string heroName { get; set; }

        public string altEgo { get; set; }

        public string primary { get; set; }

        public string secondary { get; set; }

        public string catchphrase { get; set; }
    }
}