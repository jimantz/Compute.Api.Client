﻿//------------------------------------------------------------------------------
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
    public partial class IpRangeCidrType
    {

        private string addressField;

        private int prefixSizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int prefixSize
        {
            get { return this.prefixSizeField; }
            set { this.prefixSizeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("vlan", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class VlanType
    {

        private VlanTypeNetworkDomain networkDomainField;

        private string nameField;

        private string descriptionField;

        private IpRangeCidrType privateIpv4RangeField;

        private string gatewayAddressingField;

        private string ipv4GatewayAddressField;

        private IpRangeCidrType ipv6RangeField;

        private string ipv6GatewayAddressField;

        private System.DateTime createTimeField;

        private string stateField;

        private ProgressType progressField;

        private string idField;

        private string datacenterIdField;

        private bool smallField;

		private bool attachedField;

		/// <remarks/>
		public VlanTypeNetworkDomain networkDomain
        {
            get { return this.networkDomainField; }
            set { this.networkDomainField = value; }
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
        public IpRangeCidrType privateIpv4Range
        {
            get { return this.privateIpv4RangeField; }
            set { this.privateIpv4RangeField = value; }
        } 
        
        /// <remarks/>
        public string gatewayAddressing
        {
            get { return this.gatewayAddressingField; }
            set { this.gatewayAddressingField = value; }
        }

        /// <remarks/>
        public string ipv4GatewayAddress
        {
            get { return this.ipv4GatewayAddressField; }
            set { this.ipv4GatewayAddressField = value; }
        }

        /// <remarks/>
        public IpRangeCidrType ipv6Range
        {
            get { return this.ipv6RangeField; }
            set { this.ipv6RangeField = value; }
        }

        /// <remarks/>
        public string ipv6GatewayAddress
        {
            get { return this.ipv6GatewayAddressField; }
            set { this.ipv6GatewayAddressField = value; }
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool small
        {
            get { return this.smallField; }
            set { this.smallField = value; }
        }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool attached
		{
			get { return this.attachedField; }
			set { this.attachedField = value; }
		}
	}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class VlanTypeNetworkDomain
    {

        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class vlans
    {

        private VlanType[] vlanField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vlan")]
        public VlanType[] vlan
        {
            get { return this.vlanField; }
            set { this.vlanField = value; }
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
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("deployVlan", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class DeployVlanType
	{

		private string networkDomainIdField;

		private string nameField;

		private string descriptionField;

		private string privateIpv4NetworkAddressField;

		private int privateIpv4PrefixSizeField;

		private bool privateIpv4PrefixSizeFieldSpecified;

		private object itemField;

		/// <remarks/>
		public string networkDomainId
		{
			get
			{
				return this.networkDomainIdField;
			}
			set
			{
				this.networkDomainIdField = value;
			}
		}

		/// <remarks/>
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public string privateIpv4NetworkAddress
		{
			get
			{
				return this.privateIpv4NetworkAddressField;
			}
			set
			{
				this.privateIpv4NetworkAddressField = value;
			}
		}

		/// <remarks/>
		public int privateIpv4PrefixSize
		{
			get
			{
				return this.privateIpv4PrefixSizeField;
			}
			set
			{
				this.privateIpv4PrefixSizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool privateIpv4PrefixSizeSpecified
		{
			get
			{
				return this.privateIpv4PrefixSizeFieldSpecified;
			}
			set
			{
				this.privateIpv4PrefixSizeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("attachedVlan", typeof(DeployVlanTypeAttachedVlan))]
		[System.Xml.Serialization.XmlElementAttribute("detachedVlan", typeof(DeployVlanTypeDetachedVlan))]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class DeployVlanTypeAttachedVlan
	{

		private string gatewayAddressingField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string gatewayAddressing
		{
			get
			{
				return this.gatewayAddressingField;
			}
			set
			{
				this.gatewayAddressingField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class DeployVlanTypeDetachedVlan
	{

		private string ipv4GatewayAddressField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ipv4GatewayAddress
		{
			get
			{
				return this.ipv4GatewayAddressField;
			}
			set
			{
				this.ipv4GatewayAddressField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("editVlan", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class EditVlanType
    {

        private string nameField;

        private string descriptionField;

        private string idField;

        private string ipv4GatewayAddressField;

        private string ipv6GatewayAddressField;

        /// <remarks> xs:element name="ipv6GatewayAddress" type="xs:string" minOccurs="0" nillable="true" </remarks> 
        public string ipv6GatewayAddress
        {
            get
            {
                return string.IsNullOrEmpty(this.ipv6GatewayAddressField) ? null : this.ipv6GatewayAddressField;
            }
            set
            {
                this.ipv6GatewayAddressField = value;
            }
        }

        /// <remarks> xs:element name="ipv4GatewayAddress" type="xs:string" minOccurs="0" </remarks>
        public string ipv4GatewayAddress
        {
            get
            {
                return string.IsNullOrEmpty(this.ipv4GatewayAddressField) ? null : this.ipv4GatewayAddressField;
            }
            set
            {
                this.ipv4GatewayAddressField = value;
            }
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
    [System.Xml.Serialization.XmlRootAttribute("attachVlan", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class AttachVlanType
    {

        private string gatewayAddressingField;
        
        private string idField;

        /// <remarks> gatewayAddressing may be LOW or HIGH. Will default to LOW if not specified in request. </remarks>
        public string gatewayAddressing
        {
            get { return this.gatewayAddressingField; }
            set { this.gatewayAddressingField = value; }
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
    [System.Xml.Serialization.XmlRootAttribute("detachVlan", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class DetachVlanType
    {

        private string idField;

        private string ipv4GatewayAddressField;

        private string ipv6GatewayAddressField;

        /// <remarks/>
        public string ipv4GatewayAddress
        {
            get
            {
                return this.ipv4GatewayAddressField;
            }
            set
            {
                this.ipv4GatewayAddressField = value;
            }
        }

        /// <remarks/>
        public string ipv6GatewayAddress
        {
            get
            {
                return string.IsNullOrEmpty(this.ipv6GatewayAddressField)? null : this.ipv6GatewayAddressField;
            }
            set
            {
                this.ipv6GatewayAddressField = value;
            }
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
    [System.Xml.Serialization.XmlRootAttribute("expandVlan", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class ExpandVlanType
    {

        private int privateIpv4PrefixSizeField;

        private string idField;

        /// <remarks/>
        public int privateIpv4PrefixSize
        {
            get { return this.privateIpv4PrefixSizeField; }
            set { this.privateIpv4PrefixSizeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("deleteVlan", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class DeleteVlanType
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
