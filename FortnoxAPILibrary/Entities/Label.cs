﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5466
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 

namespace FortnoxAPILibrary {
    /// <remarks/>
    public partial class Label {

      
        private string descriptionField;

        private string urlField = "";


        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
}