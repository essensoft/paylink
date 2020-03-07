using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceMailinfoQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceMailinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创建人
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [JsonPropertyName("express_company_name")]
        public string ExpressCompanyName { get; set; }

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
        /// 发票ID，发票表主键ID，用于关联发票信息
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonPropertyName("last_modifier")]
        public string LastModifier { get; set; }

        /// <summary>
        /// 邮寄日期YYYYMMDD
        /// </summary>
        [JsonPropertyName("mail_date")]
        public string MailDate { get; set; }

        /// <summary>
        /// 邮寄ID，唯一性ID，邮寄信息表唯一主键ID
        /// </summary>
        [JsonPropertyName("mail_id")]
        public string MailId { get; set; }

        /// <summary>
        /// 邮寄原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [JsonPropertyName("recipients_address")]
        public string RecipientsAddress { get; set; }

        /// <summary>
        /// 收件人名称
        /// </summary>
        [JsonPropertyName("recipients_name")]
        public string RecipientsName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [JsonPropertyName("recipients_tel")]
        public string RecipientsTel { get; set; }

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
        [JsonPropertyName("sender_tel")]
        public string SenderTel { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonPropertyName("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
