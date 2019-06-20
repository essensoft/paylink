using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EnvInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnvInfo : AlipayObject
    {
        /// <summary>
        /// 商户的操作员编号
        /// </summary>
        [JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户门店Id
        /// </summary>
        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户的终端编号
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }
    }
}
