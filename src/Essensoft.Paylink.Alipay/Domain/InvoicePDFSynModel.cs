using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoicePDFSynModel Data Structure.
    /// </summary>
    public class InvoicePDFSynModel : AlipayObject
    {
        /// <summary>
        /// 支付宝开票申请id。 当userId为空时，必填； 如果在开票过程中，是通过支付宝提交的申请到开票服务方，支付宝会带上开票申请在支付宝生成的申请id，开票服务方在回传发票的时候只需要回传这个申请id，不用获取用户的userId，支付宝可以根据申请id将发票归集到对应的用户名下
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 预留的扩展字段，格式如：key1=value1\nkey2=value2\nkey3=value3，字段之间以\n(换行符)分隔。
        /// </summary>
        [JsonPropertyName("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// base64化的字符串
        /// </summary>
        [JsonPropertyName("file_base")]
        public string FileBase { get; set; }

        /// <summary>
        /// PDF类型文件填写PDF， OFD类型文件填写ofd， JPG类型文件填写JPG(JPG文件请先询问对接人当前是否支持)
        /// </summary>
        [JsonPropertyName("file_download_type")]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 发票文件下载地址。
        /// </summary>
        [JsonPropertyName("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 外部ISV的唯一发票标识
        /// </summary>
        [JsonPropertyName("out_invoice_id")]
        public string OutInvoiceId { get; set; }

        /// <summary>
        /// 支付宝用户userId； 当apply_id为空时，userId必填
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 压缩方式
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
