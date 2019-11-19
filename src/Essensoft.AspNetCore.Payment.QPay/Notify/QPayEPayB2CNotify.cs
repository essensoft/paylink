using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Notify
{
    /// <summary>
    /// 企业付款 - 用户到账通知 (普通商户)
    /// </summary>
    [XmlRoot("xml")]
    public class QPayEPayB2CNotify : QPayNotify
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// QQ钱包业务单号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 收款用户openid
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 收款用户QQ号码
        /// </summary>
        [XmlElement("uin")]
        public string Uin { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("total_fee")]
        public int TotalFee { get; set; }

        /// <summary>
        /// 时间(红包领取或退款成功时间)
        /// </summary>
        [XmlElement("time_end")]
        public string TimeEnd { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 商户附加数据
        /// </summary>
        [XmlElement("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [XmlElement("sign_type")]
        public string SignType { get; set; }
    }
}
