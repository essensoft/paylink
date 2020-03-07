using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayForPrivilegePaidVoucherConfig Data Structure.
    /// </summary>
    public class PayForPrivilegePaidVoucherConfig : AlipayObject
    {
        /// <summary>
        /// 消费者充值赠送的该类型有偿券的数量
        /// </summary>
        [JsonPropertyName("send_count")]
        public long SendCount { get; set; }

        /// <summary>
        /// 有偿券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
