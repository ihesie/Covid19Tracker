﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Entities.Tracker
{
    public class CovidCase
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public Gender? Gender { get; set; }

        public string Nationality { get; set; }

        public CaseStatus CaseStatus { get; set; }

        public string State { get; set; }

    }

    public enum Gender
    {
        Male, Female
    }

    public enum CaseStatus
    {
        Sick, Recovered, Death
    }
}
