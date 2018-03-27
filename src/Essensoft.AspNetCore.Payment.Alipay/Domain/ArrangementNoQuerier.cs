using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("ar_nos")]
        public List<string> ArNos { get; set; }
    }
}
