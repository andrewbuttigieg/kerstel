using Microsoft.AspNet.Builder;  
using Microsoft.Extensions.DependencyInjection;

public class Startup  
{
    public void ConfigureServices(IServiceCollection services){
        services
            .AddMvcCore()
            .AddJsonFormatters();
    }
    public void Configure(IApplicationBuilder app){
        app.UseMvc();
    }
}