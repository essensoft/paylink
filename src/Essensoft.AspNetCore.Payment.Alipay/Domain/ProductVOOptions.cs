using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProductVOOptions Data Structure.
    /// </summary>
    public class ProductVOOptions : AlipayObject
    {
        /// <summary>
        /// 是否包括产品条件组信息，默认为false
        /// </summary>
        [JsonPropertyName("include_condition_group")]
        public bool IncludeConditionGroup { get; set; }

        /// <summary>
        /// 是否包括产品基本信息，默认为false
        /// </summary>
        [JsonPropertyName("include_prod_base")]
        public bool IncludeProdBase { get; set; }

        /// <summary>
        /// 是否包括产品参与者信息，默认为false
        /// </summary>
        [JsonPropertyName("include_prod_ip")]
        public bool IncludeProdIp { get; set; }

        /// <summary>
        /// 是否包括产品区域信息
        /// </summary>
        [JsonPropertyName("include_prod_lo")]
        public bool IncludeProdLo { get; set; }

        /// <summary>
        /// 是否包括产品外标信息
        /// </summary>
        [JsonPropertyName("include_prod_mark")]
        public bool IncludeProdMark { get; set; }

        /// <summary>
        /// 产品关联关系
        /// </summary>
        [JsonPropertyName("include_prod_rel")]
        public string IncludeProdRel { get; set; }

        /// <summary>
        /// 是否包括产品资源项信息
        /// </summary>
        [JsonPropertyName("include_prod_ri")]
        public bool IncludeProdRi { get; set; }
    }
}
