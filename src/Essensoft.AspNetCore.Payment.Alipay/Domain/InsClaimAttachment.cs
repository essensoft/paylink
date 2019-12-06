using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsClaimAttachment Data Structure.
    /// </summary>
    public class InsClaimAttachment : AlipayObject
    {
        /// <summary>
        /// 材料描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件对应的路径
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// 审核理由
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 材料审核状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 附件类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
