﻿namespace DD.CBU.Compute.Api.Contracts.Directory
{
	using System;
	using System.Collections.Generic;
	using System.Xml.Serialization;
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
	// This source code was auto-generated by xsd, Version=4.6.1055.0.
	// 


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("deleteUser", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class DeleteUserType
	{

		private string userNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string userName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
			}
		}
	}

}