using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrderdetailQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeOrderdetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 是否查询打款计划列表
        /// </summary>
        [JsonPropertyName("include_plans")]
        public bool IncludePlans { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 场景，固定"XFM"
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商户smid
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
