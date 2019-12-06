using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeDropdataQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeDropdataQueryModel : AlipayObject
    {
        /// <summary>
        /// 参数为：缴费业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 参数包含：业务类型、子业务类型、产品模式等
        /// </summary>
        [JsonPropertyName("search_type")]
        public string SearchType { get; set; }
    }
}
