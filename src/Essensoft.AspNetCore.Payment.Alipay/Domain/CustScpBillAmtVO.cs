using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustScpBillAmtVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustScpBillAmtVO : AlipayObject
    {
        /// <summary>
        /// 费用
        /// </summary>
        [JsonProperty("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 本金
        /// </summary>
        [JsonProperty("prin")]
        public string Prin { get; set; }
    }
}
