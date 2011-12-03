using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bothwell.ORM.Entity;
using FluentNHibernate.Mapping;

namespace Bothwell.ORM.Mapping
{
	public class RepresentativeMap : ClassMap<Employee>
	{
		public RepresentativeMap()
		{
			Id(x => x.Id);
			Map(x => x.Name);
			Map(x => x.IsCool);
		}
	}
}