using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmIsvInitializeResponse.
    /// </summary>
    public class AlipayIserviceCcmIsvInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// Base64编码CCM公钥：CCM公私钥对由CCM自动生成，用于Iframe spi接口安全认证
        /// </summary>
        [JsonPropertyName("ccm_pub_key")]
        public string CcmPubKey { get; set; }
    }
}
