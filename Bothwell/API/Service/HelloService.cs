using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bothwell.API.Command;
using Bothwell.API.Response;
using Bothwell.ORM;
using Bothwell.ORM.Entity;
using ServiceStack.ServiceHost;

namespace Bothwell.API.Service
{
	public class HelloService : IService<Hello>
	{
		public object Execute(Hello request)
		{
			int numEmployees = 0;
			var sessionFactory = BothwellOrmHost.CreateSessionFactory();
			using (var session = sessionFactory.OpenSession())
			{
				var employees = session.CreateCriteria<Employee>().List<Employee>();
				numEmployees = employees.Count;
			}

			return new HelloResponse {Result = string.Format("Hello, {0}. We have {1} employees.", request.Name, numEmployees)};
		}
	}
}