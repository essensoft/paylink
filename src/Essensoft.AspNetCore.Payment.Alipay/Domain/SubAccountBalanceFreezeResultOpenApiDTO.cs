using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubAccountBalanceFreezeResultOpenApiDTO Data Structure.
    /// </summary>
    public class SubAccountBalanceFreezeResultOpenApiDTO : AlipayObject
    {
        /// <summary>
        /// 冻结号(实际通过outBizNo作为冻结号)
        /// </summary>
        [JsonPropertyName("freeze_no")]
        public string FreezeNo { get; set; }

        /// <summary>
        /// 本次冻结金额
        /// </summary>
        [JsonPropertyName("freeze_success_amount")]
        public MultiCurrencyMoneyOpenApi FreezeSuccessAmount { get; set; }

        /// <summary>
        /// 子户余额对象(冻结后)
        /// </summary>
        [JsonPropertyName("sub_account_balance")]
        public SubAccountBalanceOpenApiDTO SubAccountBalance { get; set; }
    }
}
