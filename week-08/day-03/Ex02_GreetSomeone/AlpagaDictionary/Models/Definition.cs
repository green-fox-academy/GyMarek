using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace AlpagaDictionary.Models
{
    [Serializable()]
    public class Definition : ISerializable
    {
        public string DefinitionName { get; set; }
        public string DefinitonDescription { get; set; }

        public Definition()
        {

        }

        public void GetObjectData(SerializationInfo info,
        StreamingContext context)
        {
            info.AddValue("Name", DefinitionName);
            info.AddValue("Description", DefinitonDescription);
        }

        public Definition(SerializationInfo info,
            StreamingContext context)
        {
            DefinitionName = (string)info.GetValue("Name", typeof(string));
            DefinitonDescription = (string)info.GetValue("Description", typeof(string));
        }
    }
}
