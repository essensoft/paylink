using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("row_data")]
        public List<AlisisReportColumn> RowData { get; set; }
    }
}
