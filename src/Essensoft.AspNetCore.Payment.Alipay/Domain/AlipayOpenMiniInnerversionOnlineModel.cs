using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionOnlineModel : AlipayObject
    {
        /// <summary>
        /// 下架版本
        /// </summary>
        [JsonProperty("app_offline_version")]
        [XmlElement("app_offline_version")]
        public string AppOfflineVersion { get; set; }

        /// <summary>
        /// 上架版本
        /// </summary>
        [JsonProperty("app_online_version")]
        [XmlElement("app_online_version")]
        public string AppOnlineVersion { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
