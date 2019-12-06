using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransBillCloseModel Data Structure.
    /// </summary>
    public class AlipayFundTransBillCloseModel : AlipayObject
    {
        /// <summary>
        /// 支付宝转账单据号
        /// </summary>
        [JsonPropertyName("transfer_no")]
        public string TransferNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
