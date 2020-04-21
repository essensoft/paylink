using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieActivitySchemaModel Data Structure.
    /// </summary>
    public class FengdieActivitySchemaModel : AlipayObject
    {
        /// <summary>
        /// 指定 schema 具体数据， 格式为 schema 数据 JSON 序列化后字符串，参照模板包中 schema_path 同名的 json 文件
        /// </summary>
        [JsonPropertyName("schema_data")]
        public string SchemaData { get; set; }

        /// <summary>
        /// schema文件相对模板包根目录的路径，不需要写后缀".schema"
        /// </summary>
        [JsonPropertyName("schema_path")]
        public string SchemaPath { get; set; }
    }
}
