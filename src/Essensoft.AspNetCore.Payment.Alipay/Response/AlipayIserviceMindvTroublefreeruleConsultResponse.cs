using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceMindvTroublefreeruleConsultResponse.
    /// </summary>
    public class AlipayIserviceMindvTroublefreeruleConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 返回 true 表示未被防打扰过滤，返回false表示已被过滤
        /// </summary>
        [JsonPropertyName("result_data")]
        public bool ResultData { get; set; }
    }
}
