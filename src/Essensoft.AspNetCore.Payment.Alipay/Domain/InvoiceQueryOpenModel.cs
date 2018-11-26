using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceQueryOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceQueryOpenModel : AlipayObject
    {
        /// <summary>
        /// 申请发起方，  描述开票申请的发起角色，由销售方（PAYEE）或购买方（PAYER）发起。
        /// </summary>
        [JsonProperty("apply_from")]
        [XmlElement("apply_from")]
        public string ApplyFrom { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [JsonProperty("check_code")]
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonProperty("checker")]
        [XmlElement("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonProperty("clerk")]
        [XmlElement("clerk")]
        public string Clerk { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("einv_code")]
        [XmlElement("einv_code")]
        public string EinvCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("einv_no")]
        [XmlElement("einv_no")]
        public string EinvNo { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonProperty("ex_tax_amount")]
        [XmlElement("ex_tax_amount")]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 发票金额（加税合计）
        /// </summary>
        [JsonProperty("invoice_amount")]
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票明细项
        /// </summary>
        [JsonProperty("invoice_content")]
        [XmlArray("invoice_content")]
        [XmlArrayItem("invoice_item_query_open_model")]
        public List<InvoiceItemQueryOpenModel> InvoiceContent { get; set; }

        /// <summary>
        /// 发票日期
        /// </summary>
        [JsonProperty("invoice_date")]
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 支付宝发票id，全局唯一
        /// </summary>
        [JsonProperty("invoice_id")]
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票类型：  增值税普通电子发票(PLAIN)
        /// </summary>
        [JsonProperty("invoice_kind")]
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [JsonProperty("invoice_memo")]
        [XmlElement("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 购买方发票抬头信息
        /// </summary>
        [JsonProperty("invoice_title")]
        [XmlElement("invoice_title")]
        public InvoiceTitleQueryOpenModel InvoiceTitle { get; set; }

        /// <summary>
        /// 发票类型：蓝票/红票  BLUE（蓝票）/RED（红票）
        /// </summary>
        [JsonProperty("invoice_type")]
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的"商户品牌简称"。  如：肯德基：KFC
        /// </summary>
        [JsonProperty("m_short_name")]
        [XmlElement("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 仅用于红冲，仅用于红冲，对应红冲对应的原始蓝票的发票号码
        /// </summary>
        [JsonProperty("ori_blue_inv_code")]
        [XmlElement("ori_blue_inv_code")]
        public string OriBlueInvCode { get; set; }

        /// <summary>
        /// 仅用于红冲，仅用于红冲，对应红冲对应的原始蓝票的发票号码
        /// </summary>
        [JsonProperty("ori_blue_inv_no")]
        [XmlElement("ori_blue_inv_no")]
        public string OriBlueInvNo { get; set; }

        /// <summary>
        /// 发起方生成的开票申请唯一id，要求发起方全局唯一，支付宝依据其进行幂等控制。
        /// </summary>
        [JsonProperty("out_apply_id")]
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 申请开票对应的商户交易流水号，该流水号必须保证在同商户范围内全局唯一。
        /// </summary>
        [JsonProperty("out_trade_no")]
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonProperty("payee")]
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        [JsonProperty("payee_address")]
        [XmlElement("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销售方开户账户
        /// </summary>
        [JsonProperty("payee_bank_account")]
        [XmlElement("payee_bank_account")]
        public string PayeeBankAccount { get; set; }

        /// <summary>
        /// 销售方开户行
        /// </summary>
        [JsonProperty("payee_bank_name")]
        [XmlElement("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 销售方名称，对应于销售方纳税人识别号的名称
        /// </summary>
        [JsonProperty("payee_register_name")]
        [XmlElement("payee_register_name")]
        public string PayeeRegisterName { get; set; }

        /// <summary>
        /// 销售方纳税人识别号
        /// </summary>
        [JsonProperty("payee_register_no")]
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [JsonProperty("payee_tel")]
        [XmlElement("payee_tel")]
        public string PayeeTel { get; set; }

        /// <summary>
        /// 发票文件预览图
        /// </summary>
        [JsonProperty("preview_image_url")]
        [XmlElement("preview_image_url")]
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// 定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的"商户门店简称"。  如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003  要求："商户品牌简称+商户门店简称"作为确定商户及其下属机构的唯一标识，不可重复。
        /// </summary>
        [JsonProperty("sub_m_short_name")]
        [XmlElement("sub_m_short_name")]
        public string SubMShortName { get; set; }

        /// <summary>
        /// 合计税额
        /// </summary>
        [JsonProperty("sum_tax_amount")]
        [XmlElement("sum_tax_amount")]
        public string SumTaxAmount { get; set; }

        /// <summary>
        /// 交易发生时间
        /// </summary>
        [JsonProperty("trade_date")]
        [XmlElement("trade_date")]
        public string TradeDate { get; set; }

        /// <summary>
        /// 支付宝用户id，支付宝用户的唯一标识。
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
