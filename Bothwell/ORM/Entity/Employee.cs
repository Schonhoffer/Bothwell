using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bothwell.ORM.Entity
{
	public class Employee
	{
		public virtual int Id { get; private set; }
		public virtual string Name { get; set; }
		public virtual bool IsCool { get; set; }
	}
}