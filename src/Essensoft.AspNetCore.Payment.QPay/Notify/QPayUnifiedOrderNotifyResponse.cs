using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Notify
{
    [XmlRoot("xml")]
    public class QPayUnifiedOrderNotifyResponse : QPayNotifyResponse
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号ID
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 支付场景
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [XmlElement("trade_state")]
        public string TradeState { get; set; }

        /// <summary>
        /// 付款银行
        /// </summary>
        [XmlElement("bank_type")]
        public string BankType { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        [XmlElement("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 用户支付金额
        /// </summary>
        [XmlElement("cash_fee")]
        public string CashFee { get; set; }

        /// <summary>
        /// QQ钱包优惠金额
        /// </summary>
        [XmlElement("coupon_fee")]
        public string CouponFee { get; set; }

        /// <summary>
        /// QQ钱包订单号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 附加数据包
        /// </summary>
        [XmlElement("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        [XmlElement("time_end")]
        public string TimeEnd { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; }
    }
}
