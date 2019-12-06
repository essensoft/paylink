using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdacEasyserviceQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAntdacEasyserviceQueryModel : AlipayObject
    {
        /// <summary>
        /// 调用方法id＋询问antdac应用开发者获取＋每个方法id对应一个真实调用的接口
        /// </summary>
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// 方法所需参数＋json字符串格式＋method_id接口所需的参数
        /// </summary>
        [JsonPropertyName("parameter_json")]
        public string ParameterJson { get; set; }
    }
}
