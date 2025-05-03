using CircleCross.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace CircleCross
{
    class list_service
    {
		public void Method()
		{
			List<Item> list = new List<Item>();
			list.Add(new Item (1, "Circle,2"));
			list.Add(new Item(2, "Cross,2"));
			XmlRootAttribute root = new XmlRootAttribute();
			root.ElementName="Items";
			root.IsNullable=true;
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Item>));
			using StreamWriter sw = new StreamWriter(@"C:\items.xml");
			xmlSerializer.Serialize(sw, list);

		}
	}
}
