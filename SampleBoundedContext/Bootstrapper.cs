using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Windsor;
using SampleBoundedContext.ApplicationServices;
using SampleBoundedContext.ApplicationServices.Interfaces;
using SampleBoundedContext.Models;
using SampleBoundedContext.Models.Interfaces;

namespace SampleBoundedContext
{
    public class Bootstrapper : WindsorNancyBootstrapper
    {
        protected override void ApplicationStartup(IWindsorContainer container, IPipelines pipelines)
        {
            // No registrations should be performed in here, however you may
            // resolve things that are needed during application startup.
        }

        protected override void ConfigureApplicationContainer(IWindsorContainer existingContainer)
        {
            existingContainer.Register(Component.For<IApplicationService, ApplicationService>().LifestyleSingleton());
            existingContainer.Register(Component.For<ISampleTransientService, SampleTransientService>().LifestyleScoped<NancyPerWebRequestScopeAccessor>());
            // Perform registrations here
            base.ConfigureApplicationContainer(existingContainer);
        }

        protected override void RequestStartup(IWindsorContainer container, IPipelines pipelines, NancyContext context)
        {
            // No registrations should be performed in here, however you may
            // resolve things that are needed during request startup.
        }
    }
}