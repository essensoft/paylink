using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceKidsTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceKidsTokenCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        [JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }
    }
}
