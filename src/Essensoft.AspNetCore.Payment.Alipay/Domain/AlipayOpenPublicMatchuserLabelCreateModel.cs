using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMatchuserLabelCreateModel : AlipayObject
    {
        /// <summary>
        /// 标签id，调用创建标签接口会返回label_id
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签值，由开发者自主指定，标签值类型要满足创建标签接口中data_type参数的限定。
        /// </summary>
        [JsonPropertyName("label_value")]
        public string LabelValue { get; set; }

        /// <summary>
        /// 支付宝用户匹配器列表，最多传入10条
        /// </summary>
        [JsonPropertyName("matchers")]
        public List<Matcher> Matchers { get; set; }
    }
}
