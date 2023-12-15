using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChallengeApp.Models {
    [XmlRoot(ElementName = "vehicle")]
    public class Vehicle {
        public int Id { get; set; }
        
        [XmlElement(ElementName = "color")]
        public string Color { get; set; }

        [XmlElement(ElementName = "motor")]
        public Motor Motor { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "wheels")]
        public Wheels Wheels { get; set; }
    }


    [XmlRoot(ElementName = "vehicles")]
    public class Vehicles {

        [XmlElement(ElementName = "vehicle")]
        public List<Vehicle> Vehicle { get; set; }
    }

}
