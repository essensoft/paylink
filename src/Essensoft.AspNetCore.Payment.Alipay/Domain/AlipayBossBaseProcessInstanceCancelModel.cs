using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCancelModel Data Structure.
    /// </summary>
    public class AlipayBossBaseProcessInstanceCancelModel : AlipayObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 处理人域账号
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [JsonPropertyName("puid")]
        public string Puid { get; set; }
    }
}
