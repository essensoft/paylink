using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndirectIsvInfo Data Structure.
    /// </summary>
    public class IndirectIsvInfo : AlipayObject
    {
        /// <summary>
        /// 是否绑定间连天梭  true表示绑定  false表示未绑定
        /// </summary>
        [JsonPropertyName("is_ts_binding")]
        public string IsTsBinding { get; set; }

        /// <summary>
        /// 间连商户服务商名称
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 间连商户服务商pid
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }
    }
}
