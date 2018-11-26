using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifePayResultQueryResponse.
    /// </summary>
    public class AlipayEcoCplifePayResultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 本次交易关联的账单详情
        /// </summary>
        [JsonProperty("assoc_bill_details")]
        [XmlElement("assoc_bill_details")]
        public TradeAssocBillDetails AssocBillDetails { get; set; }

        /// <summary>
        /// 该笔缴费归属的支付宝房号，支付宝小区编号，和物业房间户号
        /// </summary>
        [JsonProperty("biz_entity_id")]
        [XmlElement("biz_entity_id")]
        public string BizEntityId { get; set; }

        /// <summary>
        /// 缴费类型：  00--上传账单类缴费  CJ--欠费直查类缴费  YC--预存类缴费
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 脱敏后的买家支付宝登录账号
        /// </summary>
        [JsonProperty("buyer_logon_id")]
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。
        /// </summary>
        [JsonProperty("buyer_user_id")]
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道
        /// </summary>
        [JsonProperty("fund_bill_list")]
        [XmlElement("fund_bill_list")]
        public FundBillListEco FundBillList { get; set; }

        /// <summary>
        /// 交易完成付款时间
        /// </summary>
        [JsonProperty("gmt_payment")]
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 卖家（即物业缴费收款方）支付宝用户号
        /// </summary>
        [JsonProperty("seller_id")]
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 本次交易支付的订单金额，单位为人民币（元）
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 用户完成物业缴费对应的支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonProperty("trade_status")]
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
