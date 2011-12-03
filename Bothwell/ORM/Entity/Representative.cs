using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bothwell.ORM.Entity
{
	public class Representative
	{
		public virtual int RepresentativeID { get; private set; }
		public virtual string Name { get; set; }
		public virtual string ImageUrl { get; set; }

		public virtual string ContactInformation { get; set; }
		public virtual string ShapeData { get; set; }
		
	}
}