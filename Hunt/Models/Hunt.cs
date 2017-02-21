using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoatHunt.Models
{
    public class Hunt
    {
        public int HuntId { get; set; }
        public string HuntName { get; set; }
        public string Type { get; set; }
        public string Permits { get; set; }
        public string HuntersAfield { get; set; }
        public string Harvest { get; set; }
        public string AverageDays { get; set; }
        public string Success { get; set; }
    }
}