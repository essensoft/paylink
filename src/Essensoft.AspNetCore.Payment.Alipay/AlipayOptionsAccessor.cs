using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayOptionsAccessor : IOptions<AlipayOptions>
    {
        public AlipayOptionsAccessor(AlipayOptions options)
        {
            Value = options;
        }

        public AlipayOptions Value { get; }
    }
}
