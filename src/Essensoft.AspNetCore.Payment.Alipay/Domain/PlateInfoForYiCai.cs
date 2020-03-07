using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PlateInfoForYiCai Data Structure.
    /// </summary>
    public class PlateInfoForYiCai : AlipayObject
    {
        /// <summary>
        /// 板块所属类型
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 板块的ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 板块名称
        /// </summary>
        [JsonPropertyName("plate_name")]
        public string PlateName { get; set; }

        /// <summary>
        /// 股票代码和股票名称
        /// </summary>
        [JsonPropertyName("symbol_name")]
        public List<string> SymbolName { get; set; }
    }
}
