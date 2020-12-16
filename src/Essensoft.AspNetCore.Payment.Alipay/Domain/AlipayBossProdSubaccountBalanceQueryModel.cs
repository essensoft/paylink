using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdSubaccountBalanceQueryModel Data Structure.
    /// </summary>
    public class AlipayBossProdSubaccountBalanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 子户余额查询请求
        /// </summary>
        [JsonPropertyName("sub_account_balance_query_order")]
        public SubAccountBalanceQueryOrder SubAccountBalanceQueryOrder { get; set; }
    }
}
