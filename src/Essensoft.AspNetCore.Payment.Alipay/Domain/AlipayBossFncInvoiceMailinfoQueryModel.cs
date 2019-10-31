using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceMailinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceMailinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 邮寄ID，唯一性ID，邮寄信息表唯一主键ID
        /// </summary>
        [JsonProperty("mail_id")]
        public string MailId { get; set; }
    }
}
