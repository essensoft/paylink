using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignVerifyModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthSignVerifyModel : AlipayObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [JsonPropertyName("request")]
        public string Request { get; set; }
    }
}
