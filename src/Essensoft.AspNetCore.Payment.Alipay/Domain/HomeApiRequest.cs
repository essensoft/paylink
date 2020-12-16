using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HomeApiRequest Data Structure.
    /// </summary>
    public class HomeApiRequest : AlipayObject
    {
        /// <summary>
        /// 业务的类型
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务唯一id，比如包裹id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 展示的内容
        /// </summary>
        [JsonPropertyName("content")]
        public List<HomeApiContent> Content { get; set; }

        /// <summary>
        /// 节点状态
        /// </summary>
        [JsonPropertyName("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
