using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceIcrowdUseResponse.
    /// </summary>
    public class AlipayDataDataserviceIcrowdUseResponse : AlipayResponse
    {
        /// <summary>
        /// 接口返回内容
        /// </summary>
        [JsonPropertyName("icrowd_use_resp")]
        public IcrowdUseResp IcrowdUseResp { get; set; }
    }
}
