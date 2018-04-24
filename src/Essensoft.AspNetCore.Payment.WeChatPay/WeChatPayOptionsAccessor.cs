using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayOptionsAccessor : IOptions<WeChatPayOptions>
    {
        public WeChatPayOptionsAccessor(WeChatPayOptions options)
        {
            Value = options;
        }

        public WeChatPayOptions Value { get; }
    }
}
