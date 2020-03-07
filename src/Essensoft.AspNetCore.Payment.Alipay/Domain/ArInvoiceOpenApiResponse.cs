using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArInvoiceOpenApiResponse Data Structure.
    /// </summary>
    public class ArInvoiceOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 发票行信息集合
        /// </summary>
        [JsonPropertyName("ar_invoice_lines")]
        public List<ArInvoiceLineOpenApiResponse> ArInvoiceLines { get; set; }

        /// <summary>
        /// 购方的地址
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
        /// 购方发票抬头，用于打印在发票上
        /// </summary>
        [JsonPropertyName("buyer_invoice_title")]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [JsonPropertyName("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购方的电话号码
        /// </summary>
        [JsonPropertyName("buyer_telephone")]
        public string BuyerTelephone { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonPropertyName("drawer")]
        public string Drawer { get; set; }

        /// <summary>
        /// 电子发票在oss上的存储地址
        /// </summary>
        [JsonPropertyName("elc_invoice_url")]
        public string ElcInvoiceUrl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 对应发票所在OU的id，用于标示该发票所述的OU。
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 票面金额
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 开票渠道，01：在线，02：线下
        /// </summary>
        [JsonPropertyName("invoice_channel")]
        public string InvoiceChannel { get; set; }

        /// <summary>
        /// 发票编码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票的开票日期，yyyyMMdd
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票ID，唯一标示一张发票
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票介质，01：电子，02：纸质
        /// </summary>
        [JsonPropertyName("invoice_material")]
        public string InvoiceMaterial { get; set; }

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
        /// 发票状态：用于标示发票当前的状态，状态类型以及相关含义  01：待开票，02：开票中，03：已开票，04：作废中，05：已作废，06：红冲中，07：已红冲，08：部分红冲，09：无效
        /// </summary>
        [JsonPropertyName("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票类型：01：专票，02：普票，03：营业税发票，04：国际形式发票，05：其它发票
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 对应发票商户的ipId，在主站标示mid，在其他环境标示ip_id。
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 商户结算的ipRoleId，表示商户的结算对象，在主站表示pid。
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最近修改人
        /// </summary>
        [JsonPropertyName("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 发票开出后的邮寄状态，具体状态说明  01：待邮寄，02：已邮寄，03：退回中，04：已退回
        /// </summary>
        [JsonPropertyName("mail_status")]
        public string MailStatus { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否为点在发票  true：是， false：不是
        /// </summary>
        [JsonPropertyName("online")]
        public bool Online { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonPropertyName("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 邮件信息的主键，用于‘根据发票邮寄ID获取当前的邮寄信息’的查询输入。
        /// </summary>
        [JsonPropertyName("recent_mail_id")]
        public string RecentMailId { get; set; }

        /// <summary>
        /// 是否红字 Y：红字， N：蓝字
        /// </summary>
        [JsonPropertyName("red")]
        public string Red { get; set; }

        /// <summary>
        /// 发票的红冲金额
        /// </summary>
        [JsonPropertyName("red_amt")]
        public MultiCurrencyMoneyOpenApi RedAmt { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonPropertyName("reviewer")]
        public string Reviewer { get; set; }

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
        /// 销方税号，用于打印在发票上
        /// </summary>
        [JsonPropertyName("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销方公司电话
        /// </summary>
        [JsonPropertyName("seller_telephone")]
        public string SellerTelephone { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
