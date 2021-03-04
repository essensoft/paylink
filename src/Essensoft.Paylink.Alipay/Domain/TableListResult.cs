using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TableListResult Data Structure.
    /// </summary>
    public class TableListResult : AlipayObject
    {
        /// <summary>
        /// 桌名
        /// </summary>
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [JsonPropertyName("table_num")]
        public string TableNum { get; set; }
    }
}
