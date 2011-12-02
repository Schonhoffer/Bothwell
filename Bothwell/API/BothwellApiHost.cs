using Funq;
using ServiceStack.WebHost.Endpoints;

public class BothwellApiHost : AppHostBase
{
	//Tell Service Stack the name of your application and where to find your web services
	public BothwellApiHost() : base("Bothwell Web Services", typeof(BothwellApiHost).Assembly) { }

	public override void Configure(Container container)
	{
		//register user-defined REST-ful urls
		//Routes
		//  .Add<Hello>("/hello")
		//  .Add<Hello>("/hello/{Name}");
	}
}