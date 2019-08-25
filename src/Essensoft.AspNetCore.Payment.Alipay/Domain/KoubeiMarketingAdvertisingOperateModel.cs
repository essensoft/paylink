using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingAdvertisingOperateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingAdvertisingOperateModel : AlipayObject
    {
        /// <summary>
        /// 广告ID，唯一标识一条广告
        /// </summary>
        [JsonProperty("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// 操作类型，目前包括上线和下线(ONLINE和OFFLINE)
        /// </summary>
        [JsonProperty("operate_type")]
        public string OperateType { get; set; }
    }
}
