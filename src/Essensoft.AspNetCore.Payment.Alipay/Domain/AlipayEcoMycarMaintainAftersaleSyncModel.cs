using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainAftersaleSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMaintainAftersaleSyncModel : AlipayObject
    {
        /// <summary>
        /// 车主平台售后编号
        /// </summary>
        [JsonPropertyName("aftersale_no")]
        public string AftersaleNo { get; set; }

        /// <summary>
        /// 客服拒绝退款原因描述
        /// </summary>
        [JsonPropertyName("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 1：受理 2：拒绝
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
