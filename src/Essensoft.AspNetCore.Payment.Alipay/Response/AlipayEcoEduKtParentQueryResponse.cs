using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtParentQueryResponse.
    /// </summary>
    public class AlipayEcoEduKtParentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 如果用户已经添加过这个孩子，则返回SUCCESS ， 失败返回FAIL。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
