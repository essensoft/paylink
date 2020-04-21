using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieActivitySchemaData Data Structure.
    /// </summary>
    public class FengdieActivitySchemaData : AlipayObject
    {
        /// <summary>
        /// 默认数据的内容，内容格式参考模板开发过程中自动生成的mock数据（与schema文件同名的json文件）。
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 指定需要初始化的schema区域，与模板中schema文件路径对应
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
