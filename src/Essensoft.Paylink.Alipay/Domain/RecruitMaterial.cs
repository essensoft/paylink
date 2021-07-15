using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RecruitMaterial Data Structure.
    /// </summary>
    public class RecruitMaterial : AlipayObject
    {
        /// <summary>
        /// 提报的素材内容，json字符串，使用时需要把此字符串解析成json对象
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 素材描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 素材名名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 关联的报名主体ID，目前都是activity_id
        /// </summary>
        [JsonPropertyName("subject_id")]
        public string SubjectId { get; set; }
    }
}
