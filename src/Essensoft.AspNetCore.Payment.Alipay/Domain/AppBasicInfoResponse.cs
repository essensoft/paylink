using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppBasicInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AppBasicInfoResponse : AlipayObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("open_app_id")]
        public string OpenAppId { get; set; }

        /// <summary>
        /// 应用的名称
        /// </summary>
        [JsonProperty("open_app_name")]
        public string OpenAppName { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonProperty("open_app_type")]
        public string OpenAppType { get; set; }
    }
}
