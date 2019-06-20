using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeContractUserhistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractUserhistoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动名
        /// </summary>
        [JsonProperty("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
