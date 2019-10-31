using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeUserclassificationCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeUserclassificationCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 用户分类类别
        /// </summary>
        [JsonProperty("classification_name")]
        public string ClassificationName { get; set; }

        /// <summary>
        /// 客户分类打标值,1:准入;0:取消
        /// </summary>
        [JsonProperty("classification_value")]
        public string ClassificationValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
