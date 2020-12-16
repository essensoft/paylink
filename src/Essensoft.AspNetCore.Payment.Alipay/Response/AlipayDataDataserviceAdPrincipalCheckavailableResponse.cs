using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalCheckavailableResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalCheckavailableResponse : AlipayResponse
    {
        /// <summary>
        /// 返回灯火商家的ID
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 查询签约状态
        /// </summary>
        [JsonPropertyName("sign_status")]
        public string SignStatus { get; set; }
    }
}
