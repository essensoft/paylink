using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCustomertagSaveModel Data Structure.
    /// </summary>
    public class AlipayUserCustomertagSaveModel : AlipayObject
    {
        /// <summary>
        /// 业务场景码。由支付宝产品经理分配，相当于存储标签的使用凭证。
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 标签名字
        /// </summary>
        [JsonPropertyName("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签值，常见为T,F
        /// </summary>
        [JsonPropertyName("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 支付宝会员uid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
