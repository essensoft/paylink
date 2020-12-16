using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSelleradmitRealtimeCertifyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSelleradmitRealtimeCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 不准入原因码
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 卖家实时准入结果
        /// </summary>
        [JsonPropertyName("result")]
        public long Result { get; set; }
    }
}
