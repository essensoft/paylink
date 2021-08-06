using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceAllResponseDTO Data Structure.
    /// </summary>
    public class InvoiceAllResponseDTO : AlipayObject
    {
        /// <summary>
        /// 发票附件的名称
        /// </summary>
        [JsonPropertyName("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// 发票附件的osskey
        /// </summary>
        [JsonPropertyName("attachment_oss_key")]
        public string AttachmentOssKey { get; set; }

        /// <summary>
        /// 购方公司地址
        /// </summary>
        [JsonPropertyName("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [JsonPropertyName("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方开户行名称
        /// </summary>
        [JsonPropertyName("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购方机构id
        /// </summary>
        [JsonPropertyName("buyer_inst_id")]
        public string BuyerInstId { get; set; }

        /// <summary>
        /// 购方发票抬头
        /// </summary>
        [JsonPropertyName("buyer_invoice_title")]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [JsonPropertyName("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购方公司电话
        /// </summary>
        [JsonPropertyName("buyer_telephone")]
        public string BuyerTelephone { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonPropertyName("exclude_tax_amt")]
        public MultiCurrencyMoneyOpenApi ExcludeTaxAmt { get; set; }

        /// <summary>
        /// 票面金额
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 发票认证时间
        /// </summary>
        [JsonPropertyName("invoice_auth_date")]
        public string InvoiceAuthDate { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期 格式(yyyy_m_mdd)
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行信息
        /// </summary>
        [JsonPropertyName("invoice_line_list")]
        public List<InvoiceLineResponseDTO> InvoiceLineList { get; set; }

        /// <summary>
        /// 发票邮寄状态code
        /// </summary>
        [JsonPropertyName("invoice_mail_status")]
        public string InvoiceMailStatus { get; set; }

        /// <summary>
        /// 发票邮寄状态name
        /// </summary>
        [JsonPropertyName("invoice_mail_status_name")]
        public string InvoiceMailStatusName { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [JsonPropertyName("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 收票日期 格式(yyyy_m_mdd)
        /// </summary>
        [JsonPropertyName("invoice_rcv_date")]
        public string InvoiceRcvDate { get; set; }

        /// <summary>
        /// 发票状态
        /// </summary>
        [JsonPropertyName("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票状态name
        /// </summary>
        [JsonPropertyName("invoice_status_name")]
        public string InvoiceStatusName { get; set; }

        /// <summary>
        /// 发票种类 code      * 01,增值税专用发票;      * 02,增值税普通发票;      * 04,国际形式发票;      * 05,其它发票
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 发票种类 name
        /// </summary>
        [JsonPropertyName("invoice_type_name")]
        public string InvoiceTypeName { get; set; }

        /// <summary>
        /// 是否红字 _y红字 _n蓝字
        /// </summary>
        [JsonPropertyName("is_red")]
        public string IsRed { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 已关联金额
        /// </summary>
        [JsonPropertyName("relevant_amt")]
        public MultiCurrencyMoneyOpenApi RelevantAmt { get; set; }

        /// <summary>
        /// 销方公司地址
        /// </summary>
        [JsonPropertyName("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        [JsonPropertyName("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销方开户行名称
        /// </summary>
        [JsonPropertyName("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 销方公司名称
        /// </summary>
        [JsonPropertyName("seller_company_name")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("seller_custm_name")]
        public string SellerCustmName { get; set; }

        /// <summary>
        /// 销方角色id
        /// </summary>
        [JsonPropertyName("seller_ip_role_id")]
        public string SellerIpRoleId { get; set; }

        /// <summary>
        /// 销方mid
        /// </summary>
        [JsonPropertyName("seller_mid")]
        public string SellerMid { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [JsonPropertyName("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销方公司电话
        /// </summary>
        [JsonPropertyName("seller_telephone")]
        public string SellerTelephone { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonPropertyName("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }
    }
}
