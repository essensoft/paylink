using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppRechargeNotifySendModel Data Structure.
    /// </summary>
    public class AlipayEbppRechargeNotifySendModel : AlipayObject
    {
        /// <summary>
        /// 充值面额或者优惠面额
        /// </summary>
        [JsonPropertyName("face_price")]
        public string FacePrice { get; set; }

        /// <summary>
        /// 充值时间或者话费券有效时间
        /// </summary>
        [JsonPropertyName("gmt_charge")]
        public string GmtCharge { get; set; }

        /// <summary>
        /// 充值的手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 阿里通信通知类型
        /// </summary>
        [JsonPropertyName("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [JsonPropertyName("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 充值交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
