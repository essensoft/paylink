using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtStudentModifyResponse.
    /// </summary>
    public class AlipayEcoEduKtStudentModifyResponse : AlipayResponse
    {
        /// <summary>
        /// Y：代表成功；N：代表失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
