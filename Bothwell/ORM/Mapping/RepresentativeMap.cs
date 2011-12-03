using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bothwell.ORM.Entity;
using FluentNHibernate.Mapping;

namespace Bothwell.ORM.Mapping
{
	public class RepresentativeMap : ClassMap<Representative>
	{
		public RepresentativeMap()
		{
			Id(x => x.RepresentativeID);
			Map(x => x.Name);
			Map(x => x.ImageUrl);
			Map(x => x.PhoneNumber);
			Map(x => x.EmailAddress);
			Map(x => x.Twitter);
			Map(x => x.ShapeData);
		}
	}
}