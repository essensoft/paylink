using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDecodeData Data Structure.
    /// </summary>
    public class AlipayMarketingDecodeData : AlipayObject
    {
        /// <summary>
        /// 钱包二维码码值
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
