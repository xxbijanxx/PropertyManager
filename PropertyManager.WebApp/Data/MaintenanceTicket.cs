﻿using System;
using PropertyManager.DataModel.Model;

namespace PropertyManager.WebApp.Data
{
    public class MaintenanceTicket
    {
        public string MaintenanceIssue { get; set; }
        public DateTime TimeSubmitted { get; set; }
        public string Urgency { get; set; }
        public Property Property { get; set; }
    }
}