using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoicePDFSynModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoicePDFSynModel : AlipayObject
    {
        /// <summary>
        /// 预留的扩展字段，格式如：key1=value1\nkey2=value2\nkey3=value3，字段之间以\n(换行符)分隔。
        /// </summary>
        [JsonProperty("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// PDF类型文件填写PDF，  JPG类型文件填写JPG(JPG文件请先询问对接人当前是否支持)
        /// </summary>
        [JsonProperty("file_download_type")]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 发票文件下载地址。
        /// </summary>
        [JsonProperty("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 外部ISV的唯一发票标识
        /// </summary>
        [JsonProperty("out_invoice_id")]
        public string OutInvoiceId { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
