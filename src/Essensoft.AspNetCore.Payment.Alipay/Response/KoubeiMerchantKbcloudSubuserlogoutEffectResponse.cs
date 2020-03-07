using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserlogoutEffectResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserlogoutEffectResponse : AlipayResponse
    {
        /// <summary>
        /// 是否登出成功
        /// </summary>
        [JsonPropertyName("flag")]
        public bool Flag { get; set; }
    }
}
