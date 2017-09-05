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
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 

namespace DD.CBU.Compute.Api.Contracts.Network20
{
	using System.Xml.Serialization;

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class SnapshotWindowType
	{

		private string idField;

		private string datacenterIdField;

		private DayOfWeekType dayOfWeekField;

		private string startHourField;

		private string availabilityStatusField;

		private int availableSlotCountField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string datacenterId
		{
			get
			{
				return this.datacenterIdField;
			}
			set
			{
				this.datacenterIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public DayOfWeekType dayOfWeek
		{
			get
			{
				return this.dayOfWeekField;
			}
			set
			{
				this.dayOfWeekField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string startHour
		{
			get
			{
				return this.startHourField;
			}
			set
			{
				this.startHourField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string availabilityStatus
		{
			get
			{
				return this.availabilityStatusField;
			}
			set
			{
				this.availabilityStatusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int availableSlotCount
		{
			get
			{
				return this.availableSlotCountField;
			}
			set
			{
				this.availableSlotCountField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public enum DayOfWeekType
	{

		/// <remarks/>
		SUNDAY,

		/// <remarks/>
		MONDAY,

		/// <remarks/>
		TUESDAY,

		/// <remarks/>
		WEDNESDAY,

		/// <remarks/>
		THURSDAY,

		/// <remarks/>
		FRIDAY,

		/// <remarks/>
		SATURDAY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class snapshotWindows
	{

		private SnapshotWindowType[] snapshotWindowField;

		private int pageNumberField;

		private bool pageNumberFieldSpecified;

		private int pageCountField;

		private bool pageCountFieldSpecified;

		private int totalCountField;

		private bool totalCountFieldSpecified;

		private int pageSizeField;

		private bool pageSizeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("snapshotWindow")]
		public SnapshotWindowType[] snapshotWindow
		{
			get
			{
				return this.snapshotWindowField;
			}
			set
			{
				this.snapshotWindowField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageNumber
		{
			get
			{
				return this.pageNumberField;
			}
			set
			{
				this.pageNumberField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageNumberSpecified
		{
			get
			{
				return this.pageNumberFieldSpecified;
			}
			set
			{
				this.pageNumberFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageCount
		{
			get
			{
				return this.pageCountField;
			}
			set
			{
				this.pageCountField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageCountSpecified
		{
			get
			{
				return this.pageCountFieldSpecified;
			}
			set
			{
				this.pageCountFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int totalCount
		{
			get
			{
				return this.totalCountField;
			}
			set
			{
				this.totalCountField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool totalCountSpecified
		{
			get
			{
				return this.totalCountFieldSpecified;
			}
			set
			{
				this.totalCountFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageSize
		{
			get
			{
				return this.pageSizeField;
			}
			set
			{
				this.pageSizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageSizeSpecified
		{
			get
			{
				return this.pageSizeFieldSpecified;
			}
			set
			{
				this.pageSizeFieldSpecified = value;
			}
		}
	}
}