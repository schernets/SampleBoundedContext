using System;
using Nancy;
using SampleBoundedContext.Models;
using SampleBoundedContext.Models.Interfaces;

namespace SampleBoundedContext.Modules
{
    public class ResourceModule : NancyModule
    {
        public ResourceModule(IApplicationService applicationService, ISampleTransientService transientService)
        {
            // would capture routes to /products/list sent as a GET request
            Get["/"] =
                parameters =>
                    new
                    {
                        ApplicationService = applicationService.GetContextBirthday(),
                        TransientService = transientService.GetTransientServiceBirthday()
                    };
        }
    }
}