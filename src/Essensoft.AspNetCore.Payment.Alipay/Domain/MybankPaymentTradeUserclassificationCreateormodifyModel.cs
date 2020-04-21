using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeUserclassificationCreateormodifyModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeUserclassificationCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 用户分类类别
        /// </summary>
        [JsonPropertyName("classification_name")]
        public string ClassificationName { get; set; }

        /// <summary>
        /// 客户分类打标值,1:准入;0:取消
        /// </summary>
        [JsonPropertyName("classification_value")]
        public string ClassificationValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
