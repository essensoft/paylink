using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasPromotionCpainfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasPromotionCpainfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 唯一应用
        /// </summary>
        [JsonProperty("app_id")]
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 应用版本
        /// </summary>
        [JsonProperty("app_version")]
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// bundle_id
        /// </summary>
        [JsonProperty("bundle_id")]
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("channel_id")]
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 调试数据
        /// </summary>
        [JsonProperty("debug")]
        [XmlElement("debug")]
        public string Debug { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("extend")]
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// IDFA
        /// </summary>
        [JsonProperty("idfa")]
        [XmlElement("idfa")]
        public string Idfa { get; set; }

        /// <summary>
        /// IOS版本
        /// </summary>
        [JsonProperty("ios_version")]
        [XmlElement("ios_version")]
        public string IosVersion { get; set; }

        /// <summary>
        /// MAC
        /// </summary>
        [JsonProperty("mac")]
        [XmlElement("mac")]
        public string Mac { get; set; }
    }
}
