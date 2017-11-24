using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// Datas Data Structure.
    /// </summary>
    public class Datas : AlipayObject
    {
        /// <summary>
        /// 指标数据区
        /// </summary>
        [JsonProperty("data")]
        public List<DataEntry> Data { get; set; }

        /// <summary>
        /// 数据维度
        /// </summary>
        [JsonProperty("dimension")]
        public List<DataDim> Dimension { get; set; }
    }
}
