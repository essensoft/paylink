using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceMailInfoOrderDTO Data Structure.
    /// </summary>
    public class InvoiceMailInfoOrderDTO : AlipayObject
    {
        /// <summary>
        /// 需要添加快递的发票信息列表
        /// </summary>
        [JsonPropertyName("invoice_ids")]
        public List<string> InvoiceIds { get; set; }

        /// <summary>
        /// 发票邮寄日期 yyyyMMdd
        /// </summary>
        [JsonPropertyName("invoice_mail_date")]
        public string InvoiceMailDate { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [JsonPropertyName("mail_company_name")]
        public string MailCompanyName { get; set; }

        /// <summary>
        /// 邮寄原因
        /// </summary>
        [JsonPropertyName("mail_reason")]
        public string MailReason { get; set; }

        /// <summary>
        /// 发票邮寄类型 01：isv寄送 02：小二寄送
        /// </summary>
        [JsonPropertyName("mail_type")]
        public string MailType { get; set; }

        /// <summary>
        /// 操作者
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [JsonPropertyName("recipient_address")]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonPropertyName("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("recipient_phone_number")]
        public string RecipientPhoneNumber { get; set; }

        /// <summary>
        /// 寄件人地址
        /// </summary>
        [JsonPropertyName("sender_address")]
        public string SenderAddress { get; set; }

        /// <summary>
        /// 寄件人名称
        /// </summary>
        [JsonPropertyName("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 寄件人电话
        /// </summary>
        [JsonPropertyName("sender_phone_number")]
        public string SenderPhoneNumber { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
