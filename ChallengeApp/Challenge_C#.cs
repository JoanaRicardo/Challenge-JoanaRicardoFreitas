﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace ChallengeApp {
    using System.Xml.Serialization;
    
    
    /// <observações/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class vehicles {
        
        private vehiclesVehicle[] vehicleField;
        
        /// <observações/>
        [System.Xml.Serialization.XmlElementAttribute("vehicle")]
        public vehiclesVehicle[] vehicle {
            get {
                return this.vehicleField;
            }
            set {
                this.vehicleField = value;
            }
        }
    }
    
    /// <observações/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class vehiclesVehicle {
        
        private vehiclesVehicleMotor motorField;
        
        private vehiclesVehicleWheel[] wheelsField;
        
        private string typeField;
        
        /// <observações/>
        public vehiclesVehicleMotor motor {
            get {
                return this.motorField;
            }
            set {
                this.motorField = value;
            }
        }
        
        /// <observações/>
        [System.Xml.Serialization.XmlArrayItemAttribute("wheel", IsNullable=false)]
        public vehiclesVehicleWheel[] wheels {
            get {
                return this.wheelsField;
            }
            set {
                this.wheelsField = value;
            }
        }
        
        /// <observações/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <observações/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class vehiclesVehicleMotor {
        
        private ushort powerField;
        
        private string typeField;
        
        /// <observações/>
        public ushort power {
            get {
                return this.powerField;
            }
            set {
                this.powerField = value;
            }
        }
        
        /// <observações/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <observações/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class vehiclesVehicleWheel {
        
        private byte sizeField;
        
        private byte pressureField;
        
        /// <observações/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <observações/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pressure {
            get {
                return this.pressureField;
            }
            set {
                this.pressureField = value;
            }
        }
    }
}
