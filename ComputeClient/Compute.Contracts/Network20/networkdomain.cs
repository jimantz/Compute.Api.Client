//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace DD.CBU.Compute.Api.Contracts.Network20
{
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("networkDomain", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class NetworkDomainType
    {

        private string nameField;

        private string descriptionField;

        private string typeField;

        private string snatIpv4AddressField;

        private IpRangeCidrType outsideTransitVlanIpv4SubnetField;

        private IpRangeCidrType outsideTransitVlanIpv6SubnetField;

        private string ipv4CpncGatewayAddressField;

        private string ipv6CpncGatewayAddressField;

        private string ipv4InternetGatewayAddressField;

        private string ipv6InternetGatewayAddressField;

        private System.DateTime createTimeField;

        private string stateField;

        private ProgressType progressField;

        private string idField;

        private string datacenterIdField;

        private bool baselineStaticRouteConfigurationField;

        /// <remarks/>
        public bool baselineStaticRouteConfiguration
        {
            get { return this.baselineStaticRouteConfigurationField; }
            set { this.baselineStaticRouteConfigurationField = value; }
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        public string snatIpv4Address
        {
            get { return this.snatIpv4AddressField; }
            set { this.snatIpv4AddressField = value; }
        }

                /// <remarks/>
        public IpRangeCidrType outsideTransitVlanIpv4Subnet {
            get {
                return this.outsideTransitVlanIpv4SubnetField;
            }
            set {
                this.outsideTransitVlanIpv4SubnetField = value;
            }
        }
        
        /// <remarks/>
        public IpRangeCidrType outsideTransitVlanIpv6Subnet {
            get {
                return this.outsideTransitVlanIpv6SubnetField;
            }
            set {
                this.outsideTransitVlanIpv6SubnetField = value;
            }
        }

        /// <remarks/>
        public string ipv4CpncGatewayAddress
        {
            get
            {
                return this.ipv4CpncGatewayAddressField;
            }
            set
            {
                this.ipv4CpncGatewayAddressField = value;
            }
        }

        /// <remarks/>
        public string ipv6CpncGatewayAddress
        {
            get
            {
                return this.ipv6CpncGatewayAddressField;
            }
            set
            {
                this.ipv6CpncGatewayAddressField = value;
            }
        }

        /// <remarks/>
        public string ipv4InternetGatewayAddress
        {
            get
            {
                return this.ipv4InternetGatewayAddressField;
            }
            set
            {
                this.ipv4InternetGatewayAddressField = value;
            }
        }

        /// <remarks/>
        public string ipv6InternetGatewayAddress
        {
            get
            {
                return this.ipv6InternetGatewayAddressField;
            }
            set
            {
                this.ipv6InternetGatewayAddressField = value;
            }
        }

        /// <remarks/>
        public System.DateTime createTime
        {
            get { return this.createTimeField; }
            set { this.createTimeField = value; }
        }

        /// <remarks/>
        public string state
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <remarks/>
        public ProgressType progress
        {
            get { return this.progressField; }
            set { this.progressField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datacenterId
        {
            get { return this.datacenterIdField; }
            set { this.datacenterIdField = value; }
        }
        
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class networkDomains
    {

        private NetworkDomainType[] networkDomainField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("networkDomain")]
        public NetworkDomainType[] networkDomain
        {
            get { return this.networkDomainField; }
            set { this.networkDomainField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber
        {
            get { return this.pageNumberField; }
            set { this.pageNumberField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified
        {
            get { return this.pageNumberFieldSpecified; }
            set { this.pageNumberFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount
        {
            get { return this.pageCountField; }
            set { this.pageCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified
        {
            get { return this.pageCountFieldSpecified; }
            set { this.pageCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount
        {
            get { return this.totalCountField; }
            set { this.totalCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified
        {
            get { return this.totalCountFieldSpecified; }
            set { this.totalCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize
        {
            get { return this.pageSizeField; }
            set { this.pageSizeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified
        {
            get { return this.pageSizeFieldSpecified; }
            set { this.pageSizeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("deployNetworkDomain", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class DeployNetworkDomainType
    {

        private string datacenterIdField;

        private string nameField;

        private string descriptionField;

        private string typeField;

        /// <remarks/>
        public string datacenterId
        {
            get { return this.datacenterIdField; }
            set { this.datacenterIdField = value; }
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("editNetworkDomain", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class EditNetworkDomainType
    {

        private string nameField;

        private string descriptionField;

        private string typeField;

        private string idField;

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("deleteNetworkDomain", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class DeleteNetworkDomainType
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("deleteStaticRoute", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class DeleteStaticRouteType
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }
}
