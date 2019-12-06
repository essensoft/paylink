using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntdataassetsOdpsColumn Data Structure.
    /// </summary>
    public class AntdataassetsOdpsColumn : AlipayObject
    {
        /// <summary>
        /// 表的字段名称
        /// </summary>
        [JsonPropertyName("column_name")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 表的字段类型
        /// </summary>
        [JsonPropertyName("column_type")]
        public string ColumnType { get; set; }
    }
}
