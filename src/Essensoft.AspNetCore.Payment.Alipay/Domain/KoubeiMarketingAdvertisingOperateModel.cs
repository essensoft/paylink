using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingAdvertisingOperateModel Data Structure.
    /// </summary>
    public class KoubeiMarketingAdvertisingOperateModel : AlipayObject
    {
        /// <summary>
        /// 广告ID，唯一标识一条广告
        /// </summary>
        [JsonPropertyName("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// 操作类型，目前包括上线和下线(ONLINE和OFFLINE)
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }
    }
}
