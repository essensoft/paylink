using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMatchuserLabelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonProperty("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 支付宝用户匹配器列表，最多传入10条
        /// </summary>
        [JsonProperty("matchers")]
        public List<Matcher> Matchers { get; set; }
    }
}
