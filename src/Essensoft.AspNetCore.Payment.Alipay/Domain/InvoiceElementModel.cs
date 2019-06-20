using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceElementModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceElementModel : AlipayObject
    {
        /// <summary>
        /// 发票报销状态  取值范围：  WAIT_EXPENSE－未报销  EXPENSE_PROCESSING－报销中  EXPENSE_FINISHED－已报销
        /// </summary>
        [JsonProperty("expense_status")]
        public string ExpenseStatus { get; set; }

        /// <summary>
        /// 发票是否有pdf文件
        /// </summary>
        [JsonProperty("has_pdf_file")]
        public bool HasPdfFile { get; set; }

        /// <summary>
        /// 该发票可能存在异常，请核实后使用  true:无异常  false:存在异常
        /// </summary>
        [JsonProperty("has_risk")]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        [JsonProperty("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票pdf文件转换后jpg预览地址
        /// </summary>
        [JsonProperty("invoice_img_url")]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 发票类型  可选值  PLAIN：增值税电子普通发票  SPECIAL：增值税专用发票  PLAIN_INVOICE:增值税普通发票  PAPER_INVOICE:增值税普通发票（卷式）  SALSE_INVOICE:机动车销售统一发票  财政电子票据：FINANCIAL_ELECTRONIC_BILL
        /// </summary>
        [JsonProperty("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态　  取值范围  SUCCEED－正常蓝票  EXPIRED－已失效
        /// </summary>
        [JsonProperty("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 服务商联系方式
        /// </summary>
        [JsonProperty("isv_contact")]
        public string IsvContact { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [JsonProperty("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// logo地址
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商户全称
        /// </summary>
        [JsonProperty("m_name")]
        public string MName { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [JsonProperty("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [JsonProperty("payee_tax_no")]
        public string PayeeTaxNo { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [JsonProperty("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [JsonProperty("payer_tax_no")]
        public string PayerTaxNo { get; set; }

        /// <summary>
        /// PDF的下载链接
        /// </summary>
        [JsonProperty("pdf_url")]
        public string PdfUrl { get; set; }
    }
}
