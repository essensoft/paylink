using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelBenefitChangeNotifyResponse.
    /// </summary>
    public class AlipayOverseasTravelBenefitChangeNotifyResponse : AlipayResponse
    {
        /// <summary>
        /// 收单站在gn的id
        /// </summary>
        [JsonPropertyName("acquirer_id")]
        public string AcquirerId { get; set; }

        /// <summary>
        /// 发卡站在gn的id
        /// </summary>
        [JsonPropertyName("psp_id")]
        public string PspId { get; set; }

        /// <summary>
        /// 通知结果
        /// </summary>
        [JsonPropertyName("result")]
        public Result Result { get; set; }
    }
}
