﻿using System;

namespace RealEstateAgency.Database
{
    public class BookOfComplaints
    {
        public int Id { get; set; }
        public int? AgentId { get; set; }
        public virtual Agent Agent { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
    }
}