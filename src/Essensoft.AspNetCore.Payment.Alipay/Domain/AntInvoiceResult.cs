using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntInvoiceResult Data Structure.
    /// </summary>
    public class AntInvoiceResult : AlipayObject
    {
        /// <summary>
        /// 防伪码
        /// </summary>
        [JsonPropertyName("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 错误编码  开票失败时返回
        /// </summary>
        [JsonPropertyName("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 错误信息 开票失败时返回
        /// </summary>
        [JsonPropertyName("biz_error_msg")]
        public string BizErrorMsg { get; set; }

        /// <summary>
        /// 发票密文，密码区的字符串
        /// </summary>
        [JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; }

        /// <summary>
        /// 税控设备编号(新版电子发票有)
        /// </summary>
        [JsonPropertyName("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 文件类型(pdf,ofd,jpg,png等等)
        /// </summary>
        [JsonPropertyName("file_data_type")]
        public string FileDataType { get; set; }

        /// <summary>
        /// 发票板式文件的下载地址。电票开票成功时必须。 下载链接是一次性的，有效期7天，如果需要再次下载的话需要重新调用接口获取。
        /// </summary>
        [JsonPropertyName("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 发票代码 开票成功时必须
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期  开票成功时必须
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 电子发票明细
        /// </summary>
        [JsonPropertyName("invoice_items")]
        public List<AntInvoiceItem> InvoiceItems { get; set; }

        /// <summary>
        /// 发票种类，0=电子发票，1=纸质发票，2=纸质专票
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public long InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码 开票成功时必须
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 开票时间，时分秒格式（注意：2019-04-11之后开具的发票才返回）
        /// </summary>
        [JsonPropertyName("invoice_time")]
        public string InvoiceTime { get; set; }

        /// <summary>
        /// 发票类型，blue=蓝票，red=红票
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 原蓝票发票代码，invoiceType=red时有值
        /// </summary>
        [JsonPropertyName("normal_invoice_code")]
        public string NormalInvoiceCode { get; set; }

        /// <summary>
        /// 原蓝票发票号码，invoiceType=red时有值
        /// </summary>
        [JsonPropertyName("normal_invoice_no")]
        public string NormalInvoiceNo { get; set; }

        /// <summary>
        /// 开票金额 开票成功时必须
        /// </summary>
        [JsonPropertyName("nvoice_amount")]
        public string NvoiceAmount { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonPropertyName("payee_checker")]
        public string PayeeChecker { get; set; }

        /// <summary>
        /// 销方企业名称
        /// </summary>
        [JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonPropertyName("payee_operator")]
        public string PayeeOperator { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonPropertyName("payee_receive")]
        public string PayeeReceive { get; set; }

        /// <summary>
        /// 销售方税号
        /// </summary>
        [JsonPropertyName("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购买方企业地址
        /// </summary>
        [JsonPropertyName("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购买方企业银行及账号
        /// </summary>
        [JsonPropertyName("payer_bankaccount")]
        public string PayerBankaccount { get; set; }

        /// <summary>
        /// 购买方抬头
        /// </summary>
        [JsonPropertyName("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购买方企业电话
        /// </summary>
        [JsonPropertyName("payer_phone")]
        public string PayerPhone { get; set; }

        /// <summary>
        /// 购买方税号
        /// </summary>
        [JsonPropertyName("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 业务平台code
        /// </summary>
        [JsonPropertyName("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 业务平台对应的订单号
        /// </summary>
        [JsonPropertyName("platform_tid")]
        public string PlatformTid { get; set; }

        /// <summary>
        /// 仅开票失败时返回此字段。  当retrying==true调用方不需要关心，阿里发票中台会自动重试。  当retrying==false调用方需要处理之后重试。这两类错误阿里发票中台是不会自动重试的：  (1)业务错误，比如折扣率计算错误之类的，需要修改报文。 (2)税盘错误，比如盘没票了，月初未抄报税等。
        /// </summary>
        [JsonPropertyName("retrying")]
        public bool Retrying { get; set; }

        /// <summary>
        /// 开票流水号，唯一标志开票请求。如果两次请求流水号相同，则表示重复请求。
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 开票状态： waiting = 等待开票中，processing = 开票中，create_success = 开票成功，create_failed = 开票失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 合计不含税金额，当开红票时，该字段为负数
        /// </summary>
        [JsonPropertyName("sum_price")]
        public string SumPrice { get; set; }

        /// <summary>
        /// 合计税额，当开红票时，该字段为负数
        /// </summary>
        [JsonPropertyName("sum_tax")]
        public string SumTax { get; set; }
    }
}
