using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class AccDetailModel : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("alipay_order_no")]
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 收款方身份认证信息。biz_scene=LOCAL时忽略该参数。
        /// </summary>
        [JsonProperty("cert_info")]
        [XmlElement("cert_info")]
        public CertInfo CertInfo { get; set; }

        /// <summary>
        /// 明细流水号
        /// </summary>
        [JsonProperty("detail_no")]
        [XmlElement("detail_no")]
        public string DetailNo { get; set; }

        /// <summary>
        /// 明细失败错误码
        /// </summary>
        [JsonProperty("error_code")]
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 明细失败错误原因
        /// </summary>
        [JsonProperty("error_msg")]
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 转账币种兑换的汇率信息。biz_scene是LOCAL场景下，该参数返回空。
        /// </summary>
        [JsonProperty("exchange_rate")]
        [XmlElement("exchange_rate")]
        public ExchangeRate ExchangeRate { get; set; }

        /// <summary>
        /// 是否需要通过alipay_order_no原单据重试.  T: 需要;  F或为空: 不需要.
        /// </summary>
        [JsonProperty("need_retry")]
        [XmlElement("need_retry")]
        public string NeedRetry { get; set; }

        /// <summary>
        /// 收款方信息。
        /// </summary>
        [JsonProperty("payee_info")]
        [XmlElement("payee_info")]
        public AccPayeeInfo PayeeInfo { get; set; }

        /// <summary>
        /// 应付金额. 付款方应付金额.  LOCAL场景下为空.
        /// </summary>
        [JsonProperty("payment_amount")]
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付币种.付款方应付的币种, 与批次请求时的payment_currency相同.
        /// </summary>
        [JsonProperty("payment_currency")]
        [XmlElement("payment_currency")]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 结算金额。  收款方实际收到的金额.  biz_scene是LOCAL场景下，该参数返回空。
        /// </summary>
        [JsonProperty("settlement_amount")]
        [XmlElement("settlement_amount")]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// 结算币种.收款方收到的币种. LOCAL场景下为空.
        /// </summary>
        [JsonProperty("settlement_currency")]
        [XmlElement("settlement_currency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// INIT：初始  APPLIED：已下单  DEALED：处理中  SUCCESS：处理成功  DISUSE：已废除  FAIL：处理失败  UNKNOWN：未知状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 转账金额。代发请求中指定的trans_amount.
        /// </summary>
        [JsonProperty("trans_amount")]
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 转账币种
        /// </summary>
        [JsonProperty("trans_currency")]
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
