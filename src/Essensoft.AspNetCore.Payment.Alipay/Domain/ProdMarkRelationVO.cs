using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdMarkRelationVO Data Structure.
    /// </summary>
    public class ProdMarkRelationVO : AlipayObject
    {
        /// <summary>
        /// 产品外标编码
        /// </summary>
        [JsonPropertyName("mark_code")]
        public string MarkCode { get; set; }

        /// <summary>
        /// 产品外标类型
        /// </summary>
        [JsonPropertyName("mark_type")]
        public string MarkType { get; set; }

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
