using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// TableInfoResult Data Structure.
    /// </summary>
    public class TableInfoResult : AlipayObject
    {
        /// <summary>
        /// 返回TableListResult集合
        /// </summary>
        [JsonProperty("table_info_list")]
        public List<TableListResult> TableInfoList { get; set; }
    }
}
