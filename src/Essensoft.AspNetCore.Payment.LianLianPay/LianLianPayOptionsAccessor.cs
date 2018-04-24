using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public class LianLianPayOptionsAccessor : IOptions<LianLianPayOptions>
    {
        public LianLianPayOptionsAccessor(LianLianPayOptions options)
        {
            Value = options;
        }

        public LianLianPayOptions Value { get; }
    }
}
