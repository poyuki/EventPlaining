﻿using System;
using System.Collections.Generic;

namespace EventPlaining.Models
{
    public class Event
    {
        public long Id { get; set; }
        public DateTime EventDateTime { get; set; }
        public string EventName { get; set; }
        public string Params { get; set; }
        public int VisitorsCount { get; set; }
        public List<Visitor> Visitors { get; set; }
    }
}