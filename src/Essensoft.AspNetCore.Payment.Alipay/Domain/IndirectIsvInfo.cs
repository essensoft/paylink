using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndirectIsvInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectIsvInfo : AlipayObject
    {
        /// <summary>
        /// 是否绑定间连天梭  true表示绑定  false表示未绑定
        /// </summary>
        [JsonProperty("is_ts_binding")]
        public string IsTsBinding { get; set; }

        /// <summary>
        /// 间连商户服务商名称
        /// </summary>
        [JsonProperty("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 间连商户服务商pid
        /// </summary>
        [JsonProperty("isv_pid")]
        public string IsvPid { get; set; }
    }
}
