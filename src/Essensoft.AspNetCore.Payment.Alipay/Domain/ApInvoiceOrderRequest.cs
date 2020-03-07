using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApInvoiceOrderRequest Data Structure.
    /// </summary>
    public class ApInvoiceOrderRequest : AlipayObject
    {
        /// <summary>
        /// （invoiceType !=07时，必填；修改操作必填）发票行信息，发票行数大于等于1，不能超过8
        /// </summary>
        [JsonPropertyName("ap_invoice_line_orders")]
        public List<ApInvoiceLineOrderRequest> ApInvoiceLineOrders { get; set; }

        /// <summary>
        /// 发票附件名称
        /// </summary>
        [JsonPropertyName("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// 发票附件key
        /// </summary>
        [JsonPropertyName("attachment_oss_key")]
        public string AttachmentOssKey { get; set; }

        /// <summary>
        /// 业务类型，为空时默认 COMMISSION
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）购方公司地址
        /// </summary>
        [JsonPropertyName("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）购方银行账号
        /// </summary>
        [JsonPropertyName("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）购方开户行名称
        /// </summary>
        [JsonPropertyName("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// （invoiceType !=07时，必填）购方机构id
        /// </summary>
        [JsonPropertyName("buyer_inst_id")]
        public string BuyerInstId { get; set; }

        /// <summary>
        /// （invoiceType !=07时，必填）购方发票抬头
        /// </summary>
        [JsonPropertyName("buyer_invoice_title")]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）购方税号
        /// </summary>
        [JsonPropertyName("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）购方公司电话
        /// </summary>
        [JsonPropertyName("buyer_telephone")]
        public string BuyerTelephone { get; set; }

        /// <summary>
        /// 票面金额，不能为空或小于等于0
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// （invoiceType != 07时，必填；修改操作必填）发票代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// （invoiceType != 07时，必填；修改操作必填）开票日期 格式(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// （invoiceType != 07时，必填；修改操作必填）发票号码
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [JsonPropertyName("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// （invoiceType != 07时，必填；修改操作必填）收票日期 格式(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("invoice_receive_date")]
        public string InvoiceReceiveDate { get; set; }

        /// <summary>
        /// （invoiceType !=07时，必填；修改操作必填）发票来源 01-手工输入 02-扫描录入
        /// </summary>
        [JsonPropertyName("invoice_source")]
        public string InvoiceSource { get; set; }

        /// <summary>
        /// 发票种类 {"01":"增值税专用发票","02":"增值税普通发票","03":"营业税发票","04":"国际形式发票","05":"其它发票","07":"虚拟发票(无法收票时使用)"} 批量新增发票时,发票类型必须一致
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否红字 Y红字 N蓝字；发票必须为蓝字发票
        /// </summary>
        [JsonPropertyName("red")]
        public string Red { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）销方公司地址
        /// </summary>
        [JsonPropertyName("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）销方银行账号
        /// </summary>
        [JsonPropertyName("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）销方开户行名称
        /// </summary>
        [JsonPropertyName("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// （invoiceType != 07时，必填；修改操作必填）销方公司名称
        /// </summary>
        [JsonPropertyName("seller_company_name")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// （invoiceType != 07时，必填；修改操作必填）销方角色id-主站为uid
        /// </summary>
        [JsonPropertyName("seller_ip_role_id")]
        public string SellerIpRoleId { get; set; }

        /// <summary>
        /// 销方mid
        /// </summary>
        [JsonPropertyName("seller_mid")]
        public string SellerMid { get; set; }

        /// <summary>
        /// （invoiceType=01时，必填）销方税号
        /// </summary>
        [JsonPropertyName("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// invoiceType=01时，必填）销方公司电话
        /// </summary>
        [JsonPropertyName("seller_telephone")]
        public string SellerTelephone { get; set; }
    }
}
