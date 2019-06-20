using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecommendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendInfo : AlipayObject
    {
        /// <summary>
        /// 支付能力聚合页地址，承载支付能力提升的页面地址。
        /// </summary>
        [JsonProperty("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 推荐运营文案，用于推荐类型为contentPage的场景。
        /// </summary>
        [JsonProperty("recommend_content")]
        public string RecommendContent { get; set; }

        /// <summary>
        /// 运营投放图片，用于推荐类型为imgPage的场景
        /// </summary>
        [JsonProperty("recommend_img")]
        public string RecommendImg { get; set; }

        /// <summary>
        /// 支付能力运营推荐类型，包括图片链接及文字链接两种，取值分别为：imgPage、contentPage
        /// </summary>
        [JsonProperty("recommend_type")]
        public string RecommendType { get; set; }
    }
}
