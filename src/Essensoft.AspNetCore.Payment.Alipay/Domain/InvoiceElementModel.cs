using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceElementModel Data Structure.
    /// </summary>
    public class InvoiceElementModel : AlipayObject
    {
        /// <summary>
        /// 发票报销状态  取值范围：  WAIT_EXPENSE－未报销  EXPENSE_PROCESSING－报销中  EXPENSE_FINISHED－已报销
        /// </summary>
        [JsonPropertyName("expense_status")]
        public string ExpenseStatus { get; set; }

        /// <summary>
        /// 发票是否有pdf文件
        /// </summary>
        [JsonPropertyName("has_pdf_file")]
        public bool HasPdfFile { get; set; }

        /// <summary>
        /// 该发票可能存在异常，请核实后使用  true:无异常  false:存在异常
        /// </summary>
        [JsonPropertyName("has_risk")]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        [JsonPropertyName("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票pdf文件转换后jpg预览地址
        /// </summary>
        [JsonPropertyName("invoice_img_url")]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 发票类型  可选值  PLAIN：增值税电子普通发票  SPECIAL：增值税专用发票  PLAIN_INVOICE:增值税普通发票  PAPER_INVOICE:增值税普通发票（卷式）  SALSE_INVOICE:机动车销售统一发票  财政电子票据：FINANCIAL_ELECTRONIC_BILL
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态　  取值范围  SUCCEED－正常蓝票  EXPIRED－已失效
        /// </summary>
        [JsonPropertyName("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 服务商联系方式
        /// </summary>
        [JsonPropertyName("isv_contact")]
        public string IsvContact { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// logo地址
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商户全称
        /// </summary>
        [JsonPropertyName("m_name")]
        public string MName { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [JsonPropertyName("payee_tax_no")]
        public string PayeeTaxNo { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [JsonPropertyName("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [JsonPropertyName("payer_tax_no")]
        public string PayerTaxNo { get; set; }

        /// <summary>
        /// PDF的下载链接
        /// </summary>
        [JsonPropertyName("pdf_url")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 该发票对应的交易
        /// </summary>
        [JsonPropertyName("trade_list")]
        public List<EinvTrade> TradeList { get; set; }

        /// <summary>
        /// 交易匹配结果 match-匹配到 noMatched-未匹配到 notMatch-未做匹配
        /// </summary>
        [JsonPropertyName("trade_match_result")]
        public string TradeMatchResult { get; set; }
    }
}
