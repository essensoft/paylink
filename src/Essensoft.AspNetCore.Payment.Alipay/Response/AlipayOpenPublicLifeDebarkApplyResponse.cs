using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeDebarkApplyResponse.
    /// </summary>
    public class AlipayOpenPublicLifeDebarkApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 下架成功后返回的提示
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
