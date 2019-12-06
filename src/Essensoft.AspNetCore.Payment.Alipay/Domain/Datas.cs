using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Datas Data Structure.
    /// </summary>
    public class Datas : AlipayObject
    {
        /// <summary>
        /// 指标数据区
        /// </summary>
        [JsonPropertyName("data")]
        public List<DataEntry> Data { get; set; }

        /// <summary>
        /// 数据维度
        /// </summary>
        [JsonPropertyName("dimension")]
        public List<DataDim> Dimension { get; set; }
    }
}
