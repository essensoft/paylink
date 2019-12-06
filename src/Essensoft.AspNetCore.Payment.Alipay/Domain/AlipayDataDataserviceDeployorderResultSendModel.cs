using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderResultSendModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceDeployorderResultSendModel : AlipayObject
    {
        /// <summary>
        /// 部署单记录id
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
