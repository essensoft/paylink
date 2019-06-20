using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementNoQuerier Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementNoQuerier : AlipayObject
    {
        /// <summary>
        /// 合约编号列表
        /// </summary>
        [JsonProperty("ar_nos")]
        public List<string> ArNos { get; set; }
    }
}
