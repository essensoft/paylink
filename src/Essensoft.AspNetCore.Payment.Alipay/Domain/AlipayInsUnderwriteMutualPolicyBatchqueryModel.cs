using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsUnderwriteMutualPolicyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsUnderwriteMutualPolicyBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 计划ID，宝贝计划(BAOBEI_PLAN)
        /// </summary>
        [JsonProperty("plan_no")]
        public string PlanNo { get; set; }

        /// <summary>
        /// 来源，如支付宝客户端(MOBILE_APP)
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
