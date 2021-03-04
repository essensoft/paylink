using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignVerifyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthSignVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditAuthPageSignVerifyResult
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
