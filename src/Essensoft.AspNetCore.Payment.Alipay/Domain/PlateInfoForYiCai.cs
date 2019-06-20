using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PlateInfoForYiCai Data Structure.
    /// </summary>
    [Serializable]
    public class PlateInfoForYiCai : AlipayObject
    {
        /// <summary>
        /// 板块所属类型
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 板块的ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 板块名称
        /// </summary>
        [JsonProperty("plate_name")]
        public string PlateName { get; set; }

        /// <summary>
        /// 股票代码和股票名称
        /// </summary>
        [JsonProperty("symbol_name")]
        public List<string> SymbolName { get; set; }
    }
}
