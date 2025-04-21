using CircleCross.Domain.Comon;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CircleCross.Domain.Comon
{
	public class BaseEntity : AuditableModel
	{
		[XmlAttribute("Id")]
		public int Id { get; set; }
	}
}