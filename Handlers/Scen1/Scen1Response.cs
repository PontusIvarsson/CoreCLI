using Handlers.Base;

namespace Handlers.Scen1
{
    public class Scen1Response : IResponse
    {
        public Scen1Response(string message)
        {
            Message = message;
        }

        public string Scen1Value { get; set; }
    }
}
