using System;
using SampleBoundedContext.Models.Interfaces;

namespace SampleBoundedContext.Models
{
    public class SampleTransientService : ISampleTransientService
    {
        private readonly DateTime _birthtDateTime;
        public SampleTransientService()
        {
            _birthtDateTime = DateTime.Now;
        }

        public string GetTransientServiceBirthday()
        {
            return "I am a Transient Service and I am brand new evrytime. My birth DateTime is " + _birthtDateTime;
        }
    }
}