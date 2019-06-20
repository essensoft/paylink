using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeBillModifyResponse.
    /// </summary>
    public class AlipayEcoCplifeBillModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 不允许修改（支付中或者支付完成）的账单明细条目列表
        /// </summary>
        [JsonProperty("alive_bill_entry_list")]
        public List<CPAliveBillEntrySet> AliveBillEntryList { get; set; }
    }
}
