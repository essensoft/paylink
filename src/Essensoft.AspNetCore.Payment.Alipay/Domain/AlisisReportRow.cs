using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlisisReportRow Data Structure.
    /// </summary>
    public class AlisisReportRow : AlipayObject
    {
        /// <summary>
        /// 报表行信息，每个对象是一列的数据
        /// </summary>
        [JsonPropertyName("row_data")]
        public List<AlisisReportColumn> RowData { get; set; }
    }
}
