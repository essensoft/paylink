using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReportDataItem Data Structure.
    /// </summary>
    public class ReportDataItem : AlipayObject
    {
        /// <summary>
        /// 表示一行数据，每个对象是一列的数据
        /// </summary>
        [JsonPropertyName("row_data")]
        public string RowData { get; set; }
    }
}
