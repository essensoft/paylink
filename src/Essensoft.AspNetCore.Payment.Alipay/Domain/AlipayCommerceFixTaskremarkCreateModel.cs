using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceFixTaskremarkCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceFixTaskremarkCreateModel : AlipayObject
    {
        /// <summary>
        /// 针对工单的补充备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 添加备注的工单id
        /// </summary>
        [JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
