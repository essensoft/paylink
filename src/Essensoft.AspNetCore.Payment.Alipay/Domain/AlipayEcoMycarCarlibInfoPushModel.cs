using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarCarlibInfoPushModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarCarlibInfoPushModel : AlipayObject
    {
        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [JsonPropertyName("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// 发动机型号
        /// </summary>
        [JsonPropertyName("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// 销售名字
        /// </summary>
        [JsonPropertyName("marker")]
        public string Marker { get; set; }

        /// <summary>
        /// 生产年份
        /// </summary>
        [JsonPropertyName("prod_year")]
        public string ProdYear { get; set; }

        /// <summary>
        /// 车系
        /// </summary>
        [JsonPropertyName("serie")]
        public string Serie { get; set; }

        /// <summary>
        /// 车款
        /// </summary>
        [JsonPropertyName("style")]
        public string Style { get; set; }
    }
}
