using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceModelContent Data Structure.
    /// </summary>
    public class InvoiceModelContent : AlipayObject
    {
        /// <summary>
        /// 支付宝端的申请id。如果在开票过程中，是通过支付宝提交的申请到机构端，支付宝会带上开票申请在支付宝生成的申请id，机构在回传发票的时候只需要回传这个申请id，不用获取用户的uid，支付宝可以根据申请id将发票归集到对应的用户名下
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// key=value，每组键值对以回车分割
        /// </summary>
        [JsonPropertyName("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 下载的发票文件类型 可选值： pdf（发票原文件） ofd (发票原文件） jpg（发票原文件缩略图）
        /// </summary>
        [JsonPropertyName("file_download_type")]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 发票原文件下载地址 1.当tax_type=PLAIN时， file_download_url必传 且file_download_type取值范围为pdf或ofd； 2.当tax_type=SPECIAL时， file_download_url必传 file_download_type可以传入pdf，ofd，jpg 3.当其他票种时，file_download_url可以不传
        /// </summary>
        [JsonPropertyName("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 财政电子票据子类型，当tax_type=FINANCIAL_ELECTRONIC_BILL时要求必填 可选值如下： 01:非税收入通用票据  02:非税收入专用票据 03:非税收入一般缴款书 04:资金往来结算票据 05:公益事业捐赠票据 06:医疗收费票据 07:社会团体会费票据 08:社会保险基金票据 09:工会经费收入票据 99:其他财政票据
        /// </summary>
        [JsonPropertyName("financial_electronic_type")]
        public string FinancialElectronicType { get; set; }

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
        /// 原始发票PDF/OFD文件流
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
        /// 税种 可选值： PLAIN：增值税电子普通发票 SPECIAL：增值税专用发票 PLAIN_INVOICE:增值税普通发票 FINANCIAL_ELECTRONIC_BILL:财政电子票据
        /// </summary>
        [JsonPropertyName("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 支付宝用户id，支付宝端的申请id存在的时候也不需要传，其他情况下，当同步的是蓝票时，必传，红票时不需传。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
