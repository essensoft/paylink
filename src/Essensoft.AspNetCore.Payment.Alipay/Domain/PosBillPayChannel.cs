using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosBillPayChannel Data Structure.
    /// </summary>
    public class PosBillPayChannel : AlipayObject
    {
        /// <summary>
        /// 支付渠道类型:  ALIPAY：ALIPAY内部渠道支付  WECHAT：WECHAT外部渠道支付
        /// </summary>
        [JsonPropertyName("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 账单支付渠道维度优惠明细
        /// </summary>
        [JsonPropertyName("discount_details")]
        public List<PosDiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// 扩展信息，json对象格式，key和value都为字符串
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 收银员ID
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 外部支付订单号,唯一标识本次支付的requestID
        /// </summary>
        [JsonPropertyName("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// 支付抵扣金额
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付渠道本身自己的支付订单号
        /// </summary>
        [JsonPropertyName("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付实收金额
        /// </summary>
        [JsonPropertyName("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 支付渠道交易号，对于支付宝是支付宝交易号，对于微信是微信交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户身份标识：手机号码、userId等
        /// </summary>
        [JsonPropertyName("user_identity")]
        public string UserIdentity { get; set; }
    }
}
