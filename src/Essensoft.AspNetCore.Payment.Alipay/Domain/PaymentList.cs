using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentList Data Structure.
    /// </summary>
    public class PaymentList : AlipayObject
    {
        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 支付优惠明细
        /// </summary>
        [JsonPropertyName("discount_infos")]
        public List<DiscountInfos> DiscountInfos { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 在线支付流水号
        /// </summary>
        [JsonPropertyName("online_payment_no")]
        public string OnlinePaymentNo { get; set; }

        /// <summary>
        /// POS支付单ID
        /// </summary>
        [JsonPropertyName("out_payment_id")]
        public string OutPaymentId { get; set; }

        /// <summary>
        /// 口碑支付单ID
        /// </summary>
        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// 支付方式，包括但不限于：  (1) ONLINE : 线上支付  (2) OFFLINE_ALIPAY：线下支付宝收款  (3) OFFLINE_WECHAT：线下微信支付  (4) OFFLINE_BANKCARD：线下银行卡支付  (5) OFFLINE_CASH : 线下现金支付  (6) OFFLINE_POINTS : 积分支付  (7) OFFLINE_STORED_VALUE_CARD : 储值卡支付  (8) OFFLINE_KOUBEI_VOUCHER : 口碑券  (9) OFFLINE_MEITUAN : 美团  (10) OFFLINE_OTHER : 线下其他支付方式
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 付款用户的标识ID
        /// </summary>
        [JsonPropertyName("user_identity")]
        public string UserIdentity { get; set; }

        /// <summary>
        /// "可枚举的付款用户的标识类型：  (1) ALIPAY:支付宝用户标识  (2)WEIXIN: 微信用户标识  (3) MOBILEPHONW:手机号"
        /// </summary>
        [JsonPropertyName("user_identity_type")]
        public string UserIdentityType { get; set; }
    }
}
