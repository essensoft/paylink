using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetPromotionApplyQueryModel Data Structure.
    /// </summary>
    public class AlipayFinancialnetPromotionApplyQueryModel : AlipayObject
    {
        /// <summary>
        /// 进件订单号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申请人支付宝UID
        /// </summary>
        [JsonPropertyName("apply_user_id")]
        public string ApplyUserId { get; set; }
    }
}
