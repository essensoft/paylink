using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdLORelationVO Data Structure.
    /// </summary>
    public class ProdLORelationVO : AlipayObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonPropertyName("lo_code")]
        public string LoCode { get; set; }

        /// <summary>
        /// 区域类型
        /// </summary>
        [JsonPropertyName("lo_type")]
        public string LoType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonPropertyName("prod_version")]
        public string ProdVersion { get; set; }
    }
}
