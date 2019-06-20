using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeContractSignpageInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractSignpageInitializeModel : AlipayObject
    {
        /// <summary>
        /// 活动标识码
        /// </summary>
        [JsonProperty("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 签约结束商户回调url, "{}"会替换成平台参数列表
        /// </summary>
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 签约来源应用标识
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用户支付宝的ID
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
