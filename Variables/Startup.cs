using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Variables
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
               
                // У цьому прикладі цей маршрут дозволяє обробити запит home/calc/10/20
                // при цьому два останні сегменти будуть доступні у методі дії calc як параметри з іменами x та y
                endpoints.MapControllerRoute(
                    name: "TwoParameterRoute",
                    pattern: "{controller}/{action}/{x=10}/{y=20}"
                    );

                // Маршрут за замовчуванням із значеннями за промовчанням.
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=home}/{action=index}"



                    );

            });
        }
    }
}