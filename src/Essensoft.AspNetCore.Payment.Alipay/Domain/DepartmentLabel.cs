using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DepartmentLabel Data Structure.
    /// </summary>
    public class DepartmentLabel : AlipayObject
    {
        /// <summary>
        /// 部门标签码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 部门标签id
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 部门标签名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
