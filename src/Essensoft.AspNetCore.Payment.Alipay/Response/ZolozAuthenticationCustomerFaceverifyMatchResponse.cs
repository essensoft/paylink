using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceverifyMatchResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceverifyMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 是否为攻击
        /// </summary>
        [JsonPropertyName("attack")]
        public bool Attack { get; set; }

        /// <summary>
        /// 人脸比对结果：成功或者失败
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
