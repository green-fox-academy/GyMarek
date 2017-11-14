using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace AlpagaDictionary.Models
{
    public class Definition
    {  
        public int Id { get; set; }
        public string DefinitionName { get; set; }
        public string DefinitonDescription { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int Score { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
