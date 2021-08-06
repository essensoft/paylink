using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoPreConsultResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoPreConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [JsonPropertyName("admittance")]
        public bool Admittance { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
