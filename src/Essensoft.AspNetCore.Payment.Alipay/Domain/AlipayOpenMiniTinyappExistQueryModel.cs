using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTinyappExistQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号ID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
