using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibCreateResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 预算库余额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 预算库编码
        /// </summary>
        [JsonPropertyName("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 消息原因，当借口异常时返回异常原因，如幂等异常时，返回原业务号对应的预算库编码
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
