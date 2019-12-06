using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenPromoPrizeDimension Data Structure.
    /// </summary>
    public class OpenPromoPrizeDimension : AlipayObject
    {
        /// <summary>
        /// 时间维度,  W：表示 周[1,4,5]  MIOD：表示 每天X分钟[0,1439]
        /// </summary>
        [JsonPropertyName("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 参考dimension 后面的值
        /// </summary>
        [JsonPropertyName("values")]
        public List<long> Values { get; set; }
    }
}
