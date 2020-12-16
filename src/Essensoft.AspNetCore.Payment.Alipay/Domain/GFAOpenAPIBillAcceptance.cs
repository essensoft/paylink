using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPIBillAcceptance Data Structure.
    /// </summary>
    public class GFAOpenAPIBillAcceptance : AlipayObject
    {
        /// <summary>
        /// 摊销扩展信息
        /// </summary>
        [JsonPropertyName("amortize_ext_info")]
        public GFAOpenAPIAmortizeExtInfo AmortizeExtInfo { get; set; }

        /// <summary>
        /// 签约合约号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 业务账单金额。（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 业务事件码（8位数字）
        /// </summary>
        [JsonPropertyName("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [JsonPropertyName("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 端事件码（8位数字）
        /// </summary>
        [JsonPropertyName("cnl_ev_code")]
        public string CnlEvCode { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [JsonPropertyName("cnl_pd_code")]
        public string CnlPdCode { get; set; }

        /// <summary>
        /// ISO 4217货币币种数值
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 收费事件码（8位数字）
        /// </summary>
        [JsonPropertyName("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 业务系统已收付款完成时间
        /// </summary>
        [JsonPropertyName("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 指定收付款时间
        /// </summary>
        [JsonPropertyName("gmt_receive")]
        public string GmtReceive { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 业务系统未收付金额（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [JsonPropertyName("nonpayment_amount")]
        public string NonpaymentAmount { get; set; }

        /// <summary>
        /// 业务流水号（受理幂等字段之一）
        /// </summary>
        [JsonPropertyName("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 业务系统收付款状态
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 收款参与者信息
        /// </summary>
        [JsonPropertyName("payee_participant")]
        public GFAOpenAPIParticipantInfo PayeeParticipant { get; set; }

        /// <summary>
        /// 付款参与者信息
        /// </summary>
        [JsonPropertyName("payer_participant")]
        public GFAOpenAPIParticipantInfo PayerParticipant { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业财受理账单扩展信息。Map<String, String> 类型JSON字符串。
        /// </summary>
        [JsonPropertyName("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 业务系统已收付金额（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [JsonPropertyName("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 业务发生量/业务发生金额。如果是金额，则为各币种的“元”单位，精确到小数点后两位。
        /// </summary>
        [JsonPropertyName("service_amount")]
        public long ServiceAmount { get; set; }

        /// <summary>
        /// 业务唯一标识（受理幂等字段之一）
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 指定结算参与者信息
        /// </summary>
        [JsonPropertyName("settle_participant")]
        public GFAOpenAPIParticipantInfo SettleParticipant { get; set; }

        /// <summary>
        /// 签约参与者信息
        /// </summary>
        [JsonPropertyName("sign_participant")]
        public GFAOpenAPIParticipantInfo SignParticipant { get; set; }

        /// <summary>
        /// 业务流水子单号（受理幂等字段之一）
        /// </summary>
        [JsonPropertyName("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [JsonPropertyName("system_origin")]
        public string SystemOrigin { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
