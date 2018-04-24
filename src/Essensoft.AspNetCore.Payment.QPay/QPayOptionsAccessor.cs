using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayOptionsAccessor : IOptions<QPayOptions>
    {
        public QPayOptionsAccessor(QPayOptions options)
        {
            Value = options;
        }

        public QPayOptions Value { get; }
    }
}
