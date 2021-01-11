using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.JoinEntries = new HashSet<EngineerMachine>(); 
        }
        public int EngineerId { get; set; }

        [DisplayName("Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime StartDate { get; set; }

        [DisplayName("Engineers Name")]
        public string EngineerName { get; set; }
        public virtual ICollection<EngineerMachine> JoinEntries { get; set; } 
    }
}

