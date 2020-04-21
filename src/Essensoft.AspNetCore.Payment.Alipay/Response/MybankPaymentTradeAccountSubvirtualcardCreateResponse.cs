using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeAccountSubvirtualcardCreateResponse.
    /// </summary>
    public class MybankPaymentTradeAccountSubvirtualcardCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 卖家主卡号，同请求参数。
        /// </summary>
        [JsonPropertyName("prim_card_no")]
        public string PrimCardNo { get; set; }

        /// <summary>
        /// 卖家子卡号户名（目前与卖家主卡户名一致）
        /// </summary>
        [JsonPropertyName("sub_virtual_card_name")]
        public string SubVirtualCardName { get; set; }

        /// <summary>
        /// 新创建的子卡号，买家可以向此卡号转账。子卡号户名与主卡号户名一致。
        /// </summary>
        [JsonPropertyName("sub_virtual_card_no")]
        public string SubVirtualCardNo { get; set; }
    }
}
