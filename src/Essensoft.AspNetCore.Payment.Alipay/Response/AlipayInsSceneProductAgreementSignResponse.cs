using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneProductAgreementSignResponse.
    /// </summary>
    public class AlipayInsSceneProductAgreementSignResponse : AlipayResponse
    {
        /// <summary>
        /// 商户签约协议号，作为签约协议的唯一业务号码
        /// </summary>
        [JsonPropertyName("product_sign_no")]
        public string ProductSignNo { get; set; }

        /// <summary>
        /// 返回签约结果，true为签约成功，false为签约失败
        /// </summary>
        [JsonPropertyName("sign_result")]
        public bool SignResult { get; set; }
    }
}
