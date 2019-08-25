using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingProductRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingProductRecommendModel : AlipayObject
    {
        /// <summary>
        /// 推荐的业务信息字段
        /// </summary>
        [JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 保险标的
        /// </summary>
        [JsonProperty("ins_object")]
        public InsObject InsObject { get; set; }

        /// <summary>
        /// 场景编码；识别商户在特定场景下需要的保险产品
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 标记推荐请求的业务来源对象
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 相关的多个干系人
        /// </summary>
        [JsonProperty("stake_holders")]
        public InsPerson StakeHolders { get; set; }

        /// <summary>
        /// 投保人
        /// </summary>
        [JsonProperty("user")]
        public InsPerson User { get; set; }
    }
}
