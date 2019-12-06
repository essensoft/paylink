using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLotteryPresentSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceLotteryPresentSendModel : AlipayObject
    {
        /// <summary>
        /// 被赠送彩票的支付宝用户的ID，不支持一次赠送给多个用户
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 彩种ID
        /// </summary>
        [JsonPropertyName("lottery_type_id")]
        public long LotteryTypeId { get; set; }

        /// <summary>
        /// 外部订单号，不超过255字符，可包含英文和数字，需保证在商户端不重复
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 彩票注数，大于0，最大为100
        /// </summary>
        [JsonPropertyName("stake_count")]
        public long StakeCount { get; set; }

        /// <summary>
        /// 赠言，不超过20个汉字
        /// </summary>
        [JsonPropertyName("swety_words")]
        public string SwetyWords { get; set; }
    }
}
