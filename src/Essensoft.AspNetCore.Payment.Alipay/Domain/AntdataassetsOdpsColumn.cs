using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntdataassetsOdpsColumn Data Structure.
    /// </summary>
    [Serializable]
    public class AntdataassetsOdpsColumn : AlipayObject
    {
        /// <summary>
        /// 表的字段名称
        /// </summary>
        [JsonProperty("column_name")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 表的字段类型
        /// </summary>
        [JsonProperty("column_type")]
        public string ColumnType { get; set; }
    }
}
