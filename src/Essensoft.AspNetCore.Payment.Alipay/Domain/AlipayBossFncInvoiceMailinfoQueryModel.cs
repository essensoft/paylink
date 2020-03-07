using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceMailinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncInvoiceMailinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 邮寄ID，唯一性ID，邮寄信息表唯一主键ID
        /// </summary>
        [JsonPropertyName("mail_id")]
        public string MailId { get; set; }
    }
}
