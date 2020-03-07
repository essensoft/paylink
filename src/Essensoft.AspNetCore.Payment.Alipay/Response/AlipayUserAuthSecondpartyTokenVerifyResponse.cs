using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAuthSecondpartyTokenVerifyResponse.
    /// </summary>
    public class AlipayUserAuthSecondpartyTokenVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 淘宝用户id
        /// </summary>
        [JsonPropertyName("tb_user_id")]
        public string TbUserId { get; set; }
    }
}
