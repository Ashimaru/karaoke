using System;

namespace SingItBetter.UI.ViewModel
{
    public class SampleService : ISampleService
    {
        public DateTime GetCurrentDateTime() => DateTime.Now;
    }

    public interface ISampleService
    {
        DateTime GetCurrentDateTime();
    }
}