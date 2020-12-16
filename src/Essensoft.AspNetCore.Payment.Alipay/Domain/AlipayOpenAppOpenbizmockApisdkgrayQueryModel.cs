using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockApisdkgrayQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppOpenbizmockApisdkgrayQueryModel : AlipayObject
    {
        /// <summary>
        /// 测试接口，参数随便配置
        /// </summary>
        [JsonPropertyName("input_param")]
        public string InputParam { get; set; }
    }
}
