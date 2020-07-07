using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 订单金额信息
    /// </summary>    
    public class Amount : WeChatPayObject
    {
        /// <summary>
        /// 订单金额
        /// 订单总金额，单位为分。
        /// 示例值：100
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 货币类型	
        /// CNY：人民币，境内商户号仅支持人民币。
        /// 示例值：CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
