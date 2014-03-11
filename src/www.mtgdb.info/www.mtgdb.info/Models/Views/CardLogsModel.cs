﻿using System;
using System.Collections.Generic;

namespace MtgDb.Info
{
    public class CardLogsModel : PageModel
    {
        public List<CardChange> Changes { get; set; }

        public CardLogsModel () : base()
        {
            Changes = new List<CardChange>();
        }
    }
}

