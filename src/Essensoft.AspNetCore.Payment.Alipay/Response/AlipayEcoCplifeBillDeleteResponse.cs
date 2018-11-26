using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeBillDeleteResponse.
    /// </summary>
    public class AlipayEcoCplifeBillDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 不允许删除（支付中或者支付完成）的账单明细条目列表
        /// </summary>
        [JsonProperty("alive_bill_entry_list")]
        [XmlArray("alive_bill_entry_list")]
        [XmlArrayItem("c_p_alive_bill_entry_set")]
        public List<CPAliveBillEntrySet> AliveBillEntryList { get; set; }
    }
}
