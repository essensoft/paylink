using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppDetectReportQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppDetectReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部业务标识
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
