using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelModifyModel : AlipayObject
    {
        /// <summary>
        /// 修改渠道信息(新增、删除、修改渠道不可同时为空)
        /// </summary>
        [JsonProperty("channels")]
        [XmlArray("channels")]
        [XmlArrayItem("kb_advert_modify_channel_request")]
        public List<KbAdvertModifyChannelRequest> Channels { get; set; }
    }
}
