using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceModelContent Data Structure.
    /// </summary>
    public class InvoiceModelContent : AlipayObject
    {
        /// <summary>
        /// key=value，每组键值对以回车分割
        /// </summary>
        [JsonPropertyName("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 下载的发票文件类型  可选值：  pdf（发票原文件）  jpg（发票原文件缩略图）
        /// </summary>
        [JsonPropertyName("file_download_type")]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 文件下载地址，当同步发票tax_type=PLAIN时，必传；  此处的链接请务必传入可下载PDF的链接
        /// </summary>
        [JsonPropertyName("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 发票金额，大于0且精确到小数点两位，以元为单位  需要传入税价合计金额
        /// </summary>
        [JsonPropertyName("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码，国税局生成的唯一值，不可为空串
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票内容项
        /// </summary>
        [JsonPropertyName("invoice_content")]
        public List<InvoiceItemContent> InvoiceContent { get; set; }

        /// <summary>
        /// 发票日期，用户填写，目前精确到日
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票防伪码
        /// </summary>
        [JsonPropertyName("invoice_fake_code")]
        public string InvoiceFakeCode { get; set; }

        /// <summary>
        /// 原始发票PDF文件流
        /// </summary>
        [JsonPropertyName("invoice_file_data")]
        public string InvoiceFileData { get; set; }

        /// <summary>
        /// 发票原始文件jpg文件地址
        /// </summary>
        [JsonPropertyName("invoice_img_url")]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 发票号码，国税局生成的唯一号码，不可为空串；  使用时请注意，invoice_no+invoice_code唯一，不能重复
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票开具操作人
        /// </summary>
        [JsonPropertyName("invoice_operator")]
        public string InvoiceOperator { get; set; }

        /// <summary>
        /// 发票title
        /// </summary>
        [JsonPropertyName("invoice_title")]
        public InvoiceTitleModel InvoiceTitle { get; set; }

        /// <summary>
        /// 发票类型，按照可选值只传入英文部分，该字段严格要求大小写  可选值:  blue（蓝票）  red（红票）
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 仅用于同步红票，原始蓝票发票代码，同步红票时必传
        /// </summary>
        [JsonPropertyName("original_blue_invoice_code")]
        public string OriginalBlueInvoiceCode { get; set; }

        /// <summary>
        /// 仅用于同步红票，原始蓝票发票号码，同步红票时必传
        /// </summary>
        [JsonPropertyName("original_blue_invoice_no")]
        public string OriginalBlueInvoiceNo { get; set; }

        /// <summary>
        /// 商户交易流水号，不可为空串;  传入红票时请注意，此字段的值要和蓝票保持一致
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户唯一开票申请业务流水号，同一个isv下不能重复
        /// </summary>
        [JsonPropertyName("out_invoice_id")]
        public string OutInvoiceId { get; set; }

        /// <summary>
        /// 开票单位地址
        /// </summary>
        [JsonPropertyName("register_address")]
        public string RegisterAddress { get; set; }

        /// <summary>
        /// 开票单位开户行账号
        /// </summary>
        [JsonPropertyName("register_bank_account")]
        public string RegisterBankAccount { get; set; }

        /// <summary>
        /// 开票单位开户行名称
        /// </summary>
        [JsonPropertyName("register_bank_name")]
        public string RegisterBankName { get; set; }

        /// <summary>
        /// 开票单位
        /// </summary>
        [JsonPropertyName("register_name")]
        public string RegisterName { get; set; }

        /// <summary>
        /// 纳税人识别号，不可为空串
        /// </summary>
        [JsonPropertyName("register_no")]
        public string RegisterNo { get; set; }

        /// <summary>
        /// 开票人电话，支持座机和手机两种格式
        /// </summary>
        [JsonPropertyName("register_phone_no")]
        public string RegisterPhoneNo { get; set; }

        /// <summary>
        /// 价税合计
        /// </summary>
        [JsonPropertyName("sum_amount")]
        public string SumAmount { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonPropertyName("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税种  可选值：  PLAIN（普票的情况）  SPECIAL（专票的情况）
        /// </summary>
        [JsonPropertyName("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 支付宝用户id,当同步的是蓝票时，必传。红票时不需传。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
