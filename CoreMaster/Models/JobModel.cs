using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMaster.Models
{
    public class JobModel
    {
        public int JobID { get; set; }
        public string JobTitle { get; set; }
        public int CityId { get; set; }
        public string JobImage { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBY { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBY { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int JobState { get; set; }
    }
}