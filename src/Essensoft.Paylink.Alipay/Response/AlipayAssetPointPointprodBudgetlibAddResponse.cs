using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibAddResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibAddResponse : AlipayResponse
    {
        /// <summary>
        /// 当order_no发生幂等时返回的错误信息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
