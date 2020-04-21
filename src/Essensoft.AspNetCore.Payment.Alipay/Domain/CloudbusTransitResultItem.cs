using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusTransitResultItem Data Structure.
    /// </summary>
    public class CloudbusTransitResultItem : AlipayObject
    {
        /// <summary>
        /// 接口状态码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 公交客流走廊列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<CloudbusTransitItem> Data { get; set; }

        /// <summary>
        /// 消息描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
