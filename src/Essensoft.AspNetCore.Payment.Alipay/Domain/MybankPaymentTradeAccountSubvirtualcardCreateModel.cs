using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeAccountSubvirtualcardCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeAccountSubvirtualcardCreateModel : AlipayObject
    {
        /// <summary>
        /// 买家标识
        /// </summary>
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 卖家主卡户名
        /// </summary>
        [JsonProperty("prim_card_name")]
        public string PrimCardName { get; set; }

        /// <summary>
        /// 卖家主卡号
        /// </summary>
        [JsonProperty("prim_card_no")]
        public string PrimCardNo { get; set; }
    }
}
