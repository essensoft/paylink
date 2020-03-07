using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// ISV流水号，用于控制幂等，须确保全局唯一
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
