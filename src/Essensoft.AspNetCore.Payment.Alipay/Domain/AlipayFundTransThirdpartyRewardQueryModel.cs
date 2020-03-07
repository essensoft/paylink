using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardQueryModel Data Structure.
    /// </summary>
    public class AlipayFundTransThirdpartyRewardQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码，接入时找业务方分配
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 付款方支付宝UserId
        /// </summary>
        [JsonPropertyName("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 打赏单据号
        /// </summary>
        [JsonPropertyName("transfer_no")]
        public string TransferNo { get; set; }
    }
}
