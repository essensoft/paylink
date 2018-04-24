using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public class JDPayOptionsAccessor : IOptions<JDPayOptions>
    {
        public JDPayOptionsAccessor(JDPayOptions options)
        {
            Value = options;
        }

        public JDPayOptions Value { get; }
    }
}
