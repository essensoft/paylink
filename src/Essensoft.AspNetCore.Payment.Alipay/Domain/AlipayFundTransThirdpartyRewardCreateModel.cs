using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardCreateModel Data Structure.
    /// </summary>
    public class AlipayFundTransThirdpartyRewardCreateModel : AlipayObject
    {
        /// <summary>
        /// 打赏金额，单位：人民币分
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展参数，json格式
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 外部业务号，用于幂等控制
        /// </summary>
        [JsonPropertyName("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 收款用户的支付宝userId
        /// </summary>
        [JsonPropertyName("receiver_user_id")]
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// 场景码，需业务方分配方可使用
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 付款用户的支付宝userId
        /// </summary>
        [JsonPropertyName("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 打赏的标题（理由）
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
