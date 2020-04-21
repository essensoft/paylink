using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeAccountSubvirtualcardCreateModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeAccountSubvirtualcardCreateModel : AlipayObject
    {
        /// <summary>
        /// 买家标识
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 卖家主卡户名
        /// </summary>
        [JsonPropertyName("prim_card_name")]
        public string PrimCardName { get; set; }

        /// <summary>
        /// 卖家主卡号
        /// </summary>
        [JsonPropertyName("prim_card_no")]
        public string PrimCardNo { get; set; }
    }
}
