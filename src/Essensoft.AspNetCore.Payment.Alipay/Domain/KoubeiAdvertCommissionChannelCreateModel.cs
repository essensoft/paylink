using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelCreateModel : AlipayObject
    {
        /// <summary>
        /// 新增渠道列表
        /// </summary>
        [JsonProperty("channels")]
        [XmlArray("channels")]
        [XmlArrayItem("kb_advert_add_channel_request")]
        public List<KbAdvertAddChannelRequest> Channels { get; set; }
    }
}
