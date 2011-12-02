using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Bothwell.ORM
{
	public class BothwellOrmHost
	{
		private const string ConnectionStringConfigKey = "MySqlDb";

		public static ISessionFactory CreateSessionFactory()
		{
			return CreateConfig().BuildSessionFactory();
		}

		private static FluentConfiguration CreateConfig()
		{
			return Fluently.Configure().Database(
				MySQLConfiguration.Standard.ConnectionString(c => c.FromConnectionStringWithKey(ConnectionStringConfigKey)))
				.Mappings(m => m.FluentMappings.AddFromAssemblyOf<BothwellOrmHost>());
		}

		public static void BuildSchema(NHibernate.Cfg.Configuration config)
		{
			CreateConfig().ExposeConfiguration(c => new SchemaExport(config).Create(false, true));
		}
	}
}