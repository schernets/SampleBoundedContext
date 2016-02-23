using System;
using SampleBoundedContext.ApplicationServices.Interfaces;

namespace SampleBoundedContext.ApplicationServices
{
    public class ApplicationService : IApplicationService
    {
        private readonly DateTime _birthtDateTime;
        public ApplicationService()
        {
            _birthtDateTime = DateTime.Now;
        }

        public string GetContextBirthday()
        {
            return "I am a Sample Bounded Context and I am OLD: " + _birthtDateTime;
        }
    }
}