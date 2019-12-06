using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoteDataModel Data Structure.
    /// </summary>
    public class PromoteDataModel : AlipayObject
    {
        /// <summary>
        /// 核销数
        /// </summary>
        [JsonPropertyName("checked_voucher_num")]
        public long CheckedVoucherNum { get; set; }

        /// <summary>
        /// 领券数
        /// </summary>
        [JsonPropertyName("claim_voucher_num")]
        public long ClaimVoucherNum { get; set; }

        /// <summary>
        /// 分佣金额
        /// </summary>
        [JsonPropertyName("commission_amount")]
        public string CommissionAmount { get; set; }
    }
}
