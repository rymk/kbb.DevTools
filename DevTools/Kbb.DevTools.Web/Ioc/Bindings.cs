using Kbb.DevTools.Business.Services;
using Kbb.DevTools.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Kbb.ReturnManger.Web.Ioc
{
    public class Bindings
    {
        public Bindings() { }

        // TODO: modularize these at some point and move them out of the Web Project if makes sense
        public void LoadBindings(IServiceCollection services)
        {
            services.AddScoped<IReturnService, ReturnService>();
        }
    }
}
