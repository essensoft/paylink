using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BuyerInfo Data Structure.
    /// </summary>
    public class BuyerInfo : AlipayObject
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }
    }
}
