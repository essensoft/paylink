using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstitutionInfo Data Structure.
    /// </summary>
    public class InstitutionInfo : AlipayObject
    {
        /// <summary>
        /// 期望入库时间 不传则立即入库
        /// </summary>
        [JsonPropertyName("face_in_time")]
        public string FaceInTime { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
