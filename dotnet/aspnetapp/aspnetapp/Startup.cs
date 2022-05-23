using Elastic.Apm.AspNetCore;
public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(IApplicationBuilder app, IHostEnvironment env)
    {
        //Registers the agent with an IConfiguration instance:
        app.UseElasticApm(_configuration);

        //Rest of the Configure() method...
    }
}