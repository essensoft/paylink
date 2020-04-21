using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffProduceqrcodeBatchqueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffProduceqrcodeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前是否还有生产指令可以拉取；注意如果该值为false，也只有提示当前没有更多生产指令了，不代表后面没有生产指令，商户自己需要制定策略定时去拉取
        /// </summary>
        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 口碑码列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<AccessProduceQrcode> List { get; set; }
    }
}
