﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace RestAPIDemo
{
    public partial class questions
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string questions1 { get; set; }
        public string answers { get; set; }
        public int? created_by { get; set; }
        public DateTime? created_date { get; set; }
        public int? updated_by { get; set; }
        public DateTime? update_date { get; set; }
        public int? topicDep { get; set; }
    }
}