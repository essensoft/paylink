using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiContentContentcountSetModel Data Structure.
    /// </summary>
    public class KoubeiContentContentcountSetModel : AlipayObject
    {
        /// <summary>
        /// 口碑端内容唯一id，必填
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 数字
        /// </summary>
        [JsonPropertyName("num")]
        public long Num { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
