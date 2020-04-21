using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementNoQuerier Data Structure.
    /// </summary>
    public class ArrangementNoQuerier : AlipayObject
    {
        /// <summary>
        /// 合约编号列表
        /// </summary>
        [JsonPropertyName("ar_nos")]
        public List<string> ArNos { get; set; }
    }
}
