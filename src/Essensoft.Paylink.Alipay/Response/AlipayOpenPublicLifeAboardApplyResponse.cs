using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAboardApplyResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAboardApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 上架成功后返回的提示
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
