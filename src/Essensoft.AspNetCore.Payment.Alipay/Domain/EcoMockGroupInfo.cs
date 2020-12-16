using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EcoMockGroupInfo Data Structure.
    /// </summary>
    public class EcoMockGroupInfo : AlipayObject
    {
        /// <summary>
        /// appId
        /// </summary>
        [JsonPropertyName("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 挡板数
        /// </summary>
        [JsonPropertyName("mock_count")]
        public long MockCount { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分组状态: INUSE/UNUSE
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
