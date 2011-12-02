using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bothwell.ORM.Entity;
using FluentNHibernate.Mapping;

namespace Bothwell.ORM.Mapping
{
	public class EmployeeMap : ClassMap<Employee>
	{
		public EmployeeMap()
		{
			Id(x => x.Id);
			Map(x => x.Name);
			Map(x => x.IsCool);
		}
	}
}