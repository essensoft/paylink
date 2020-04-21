using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustomerTag Data Structure.
    /// </summary>
    public class CustomerTag : AlipayObject
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonPropertyName("col_name")]
        public string ColName { get; set; }

        /// <summary>
        /// column_type字段类型
        /// </summary>
        [JsonPropertyName("column_type")]
        public string ColumnType { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
