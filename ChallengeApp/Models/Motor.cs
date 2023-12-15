using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChallengeApp.Models {
    [XmlType(TypeName = "motor")]
    public class Motor {
        public int Id { get; set; }

        [XmlElement(ElementName = "power")]
        public int Power { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

    }
}
