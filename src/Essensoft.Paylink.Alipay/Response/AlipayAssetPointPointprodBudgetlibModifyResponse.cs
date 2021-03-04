using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibModifyResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 预算库有效期修改失败时的错误信息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
