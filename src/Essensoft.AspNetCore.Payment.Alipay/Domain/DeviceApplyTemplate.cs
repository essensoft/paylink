using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceApplyTemplate Data Structure.
    /// </summary>
    public class DeviceApplyTemplate : AlipayObject
    {
        /// <summary>
        /// 实际申请数量，取值1到500之间，最多不能超过500。补充说明：一次能申请的机具模板种类最多为10，也就是device_list大小为10
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 机具模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
