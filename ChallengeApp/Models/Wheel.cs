using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChallengeApp.Models {
    [XmlType(TypeName = "wheel")]
    public class Wheel {
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "size")]
        public int Size { get; set; }

        [XmlAttribute(AttributeName = "pressure")]
        public int Pressure { get; set; }
    }


    [XmlType(TypeName = "wheels")]
    public class Wheels {

        [XmlElement(ElementName = "wheel")]
        public List<Wheel> Wheel { get; set; }
    }
}
