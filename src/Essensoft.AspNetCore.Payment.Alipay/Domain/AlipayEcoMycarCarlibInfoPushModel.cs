using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarCarlibInfoPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCarlibInfoPushModel : AlipayObject
    {
        /// <summary>
        /// 品牌
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [JsonProperty("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// 发动机型号
        /// </summary>
        [JsonProperty("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// 销售名字
        /// </summary>
        [JsonProperty("marker")]
        public string Marker { get; set; }

        /// <summary>
        /// 生产年份
        /// </summary>
        [JsonProperty("prod_year")]
        public string ProdYear { get; set; }

        /// <summary>
        /// 车系
        /// </summary>
        [JsonProperty("serie")]
        public string Serie { get; set; }

        /// <summary>
        /// 车款
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }
    }
}
