using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntries = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string MachineName { get; set; }

    [DisplayName("Mchines Functionality:")]
    public string MachineFunctionality { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntries { get; set;}
  }
}  