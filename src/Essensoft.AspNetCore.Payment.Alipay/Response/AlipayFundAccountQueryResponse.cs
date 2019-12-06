using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundAccountQueryResponse.
    /// </summary>
    public class AlipayFundAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可用余额。可用于支付或提现的余额。
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 场景余额模式外标卡信息
        /// </summary>
        [JsonPropertyName("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }
    }
}
