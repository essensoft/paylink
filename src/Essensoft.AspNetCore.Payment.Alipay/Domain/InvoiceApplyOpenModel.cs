using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceApplyOpenModel Data Structure.
    /// </summary>
    public class InvoiceApplyOpenModel : AlipayObject
    {
        /// <summary>
        /// 复核人
        /// </summary>
        [JsonPropertyName("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("clerk")]
        public string Clerk { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonPropertyName("ex_tax_amount")]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 发票金额（加税合计）
        /// </summary>
        [JsonPropertyName("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票内容项
        /// </summary>
        [JsonPropertyName("invoice_content")]
        public List<InvoiceItemApplyOpenModel> InvoiceContent { get; set; }

        /// <summary>
        /// 发票类型：  增值税普通电子发票(PLAIN)
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [JsonPropertyName("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonPropertyName("invoice_title")]
        public InvoiceTitleApplyOpenModel InvoiceTitle { get; set; }

        /// <summary>
        /// 仅用于红冲，对应红冲对应的原始蓝票的发票代码，红冲时该字段必填，开蓝票时该字段不需填
        /// </summary>
        [JsonPropertyName("ori_blue_inv_code")]
        public string OriBlueInvCode { get; set; }

        /// <summary>
        /// 仅用于红冲，对应红冲对应的原始蓝票的发票号码，红冲时该字段必填，开蓝票时该字段不需填
        /// </summary>
        [JsonPropertyName("ori_blue_inv_no")]
        public string OriBlueInvNo { get; set; }

        /// <summary>
        /// 发起方生成的开票申请唯一id，要求发起方全局唯一，支付宝依据其进行幂等控制。
        /// </summary>
        [JsonPropertyName("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 为外部系统提供的扩展信息透传字段，可在开票申请中传入，开票成功后从发票信息中取回。 格式：key1=value2|key2=value2
        /// </summary>
        [JsonPropertyName("out_extends")]
        public string OutExtends { get; set; }

        /// <summary>
        /// 申请开票对应的商户交易流水号，该流水号必须保证在同商户范围内全局唯一。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonPropertyName("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        [JsonPropertyName("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销售方开户账户
        /// </summary>
        [JsonPropertyName("payee_bank_account")]
        public string PayeeBankAccount { get; set; }

        /// <summary>
        /// 销售方开户行
        /// </summary>
        [JsonPropertyName("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 销售方名称，对应于销售方纳税人识别号的名称
        /// </summary>
        [JsonPropertyName("payee_register_name")]
        public string PayeeRegisterName { get; set; }

        /// <summary>
        /// 销售方纳税人识别号
        /// </summary>
        [JsonPropertyName("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [JsonPropertyName("payee_tel")]
        public string PayeeTel { get; set; }

        /// <summary>
        /// 购买方联系方式-邮箱，商家开蓝票时，该字段必填，使用该邮箱向购买方发送发票pdf文件。其它情况均可不传
        /// </summary>
        [JsonPropertyName("payer_contact_email")]
        public string PayerContactEmail { get; set; }

        /// <summary>
        /// 购买方联系方式，依据税控厂商的要求，如若底层税控对接的是浙江航信，该字段必传，其它情况可不传
        /// </summary>
        [JsonPropertyName("payer_contact_mobile")]
        public string PayerContactMobile { get; set; }

        /// <summary>
        /// 合计税额
        /// </summary>
        [JsonPropertyName("sum_tax_amount")]
        public string SumTaxAmount { get; set; }

        /// <summary>
        /// 商户在税控服务开通后，税控厂商会向商户分配秘钥并提供token的生成方法，商户或ISV利用该方法生成token以获得此次调用的操作权限。目前对于阿里平台来说，不需要校验该权限，如果底层税控对接的是阿里平台的话，该字段可不填，其它的税控厂商该字段为必填
        /// </summary>
        [JsonPropertyName("tax_token")]
        public string TaxToken { get; set; }

        /// <summary>
        /// 交易发生时间,依据税控厂商要求，目前底层税控对接的是浙江航信的话，该字段必填
        /// </summary>
        [JsonPropertyName("trade_date")]
        public string TradeDate { get; set; }
    }
}
