using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncSubaccountBalanceFreezeModel Data Structure.
    /// </summary>
    public class AlipayBossFncSubaccountBalanceFreezeModel : AlipayObject
    {
        /// <summary>
        /// 子户余额冻结请求
        /// </summary>
        [JsonPropertyName("sub_account_balance_freeze_order")]
        public SubAccountBalanceFreezeOrder SubAccountBalanceFreezeOrder { get; set; }
    }
}
