using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeUseridentityStatusUpdateModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeUseridentityStatusUpdateModel : AlipayObject
    {
        /// <summary>
        /// 业务明细
        /// </summary>
        [JsonPropertyName("biz_details")]
        public string BizDetails { get; set; }

        /// <summary>
        /// 当前业务状态
        /// </summary>
        [JsonPropertyName("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 业务单据ID
        /// </summary>
        [JsonPropertyName("req_id")]
        public string ReqId { get; set; }
    }
}
