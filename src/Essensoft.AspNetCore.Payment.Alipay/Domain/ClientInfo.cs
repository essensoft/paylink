using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ClientInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ClientInfo : AlipayObject
    {
        /// <summary>
        /// 目前支持4个值  en：英文  zh-Hans：简体中文  zh-Hant：繁体台湾  zh-HK：繁体香港  默认值是zh-Hans
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// 操作系统  目前支持  ios  android
        /// </summary>
        [JsonProperty("os")]
        public string Os { get; set; }

        /// <summary>
        /// 客户端类型,目前支持alipay,uc
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 客户端的版本号
        /// </summary>
        [JsonProperty("version_no")]
        public string VersionNo { get; set; }
    }
}
