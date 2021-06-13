using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConsultResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 签约咨询返回的JSON信息
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
