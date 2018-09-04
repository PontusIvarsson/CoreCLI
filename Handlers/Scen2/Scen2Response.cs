using Handlers.Base;

namespace Handlers.Scen1
{
    public class Scen2Response : IResponse
    {
        public Scen2Response
            (string message)
        {
            Message = message;
        }

        public string Scen2Value { get; set; }
    }
}
