using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppApiSceneQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppApiSceneQueryModel : AlipayObject
    {
        /// <summary>
        /// 接口英文名。
        /// </summary>
        [JsonPropertyName("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 接口出参字段英文名。
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }
    }
}
