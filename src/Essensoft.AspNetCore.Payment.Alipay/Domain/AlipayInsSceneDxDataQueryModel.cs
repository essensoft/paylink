using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneDxDataQueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneDxDataQueryModel : AlipayObject
    {
        /// <summary>
        /// dx服务名
        /// </summary>
        [JsonPropertyName("dx_name")]
        public string DxName { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        [JsonPropertyName("param")]
        public string Param { get; set; }
    }
}
