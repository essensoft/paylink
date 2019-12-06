using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TableInfoResult Data Structure.
    /// </summary>
    public class TableInfoResult : AlipayObject
    {
        /// <summary>
        /// 返回TableListResult集合
        /// </summary>
        [JsonPropertyName("table_info_list")]
        public List<TableListResult> TableInfoList { get; set; }
    }
}
