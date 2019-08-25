using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransThirdpartyRewardQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码，接入时找业务方分配
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 付款方支付宝UserId
        /// </summary>
        [JsonProperty("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 打赏单据号
        /// </summary>
        [JsonProperty("transfer_no")]
        public string TransferNo { get; set; }
    }
}
