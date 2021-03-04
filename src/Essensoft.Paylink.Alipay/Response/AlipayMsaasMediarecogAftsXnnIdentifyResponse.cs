using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsXnnIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAftsXnnIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 算法返回结果，json字符串
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
