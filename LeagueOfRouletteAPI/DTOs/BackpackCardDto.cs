﻿using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Controllers
{
    public class BackpackCardDto
    {
        public int BackpackCardId { get; set; }
        public Card Card { get; set; }
    }
}
