using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicThirdCustomerServiceModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicThirdCustomerServiceModel : AlipayObject
    {
        /// <summary>
        /// 服务窗商户在渠道商处对应的用户id
        /// </summary>
        [JsonProperty("channel_uid")]
        [XmlElement("channel_uid")]
        public string ChannelUid { get; set; }
    }
}
