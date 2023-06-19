﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Core.Entities
{
    public class List : Entity
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public List<Card> Cards { get; set; }
    }
}
