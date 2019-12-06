using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeRepairStatusUpdateModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeRepairStatusUpdateModel : AlipayObject
    {
        /// <summary>
        /// 报修单状态明细
        /// </summary>
        [JsonPropertyName("biz_details")]
        public string BizDetails { get; set; }

        /// <summary>
        /// 当前报修单状态
        /// </summary>
        [JsonPropertyName("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 报修单ID
        /// </summary>
        [JsonPropertyName("req_id")]
        public string ReqId { get; set; }
    }
}
