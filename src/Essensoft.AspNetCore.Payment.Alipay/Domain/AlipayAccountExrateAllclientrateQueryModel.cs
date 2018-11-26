using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateAllclientrateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateAllclientrateQueryModel : AlipayObject
    {
        /// <summary>
        /// 客户id，客户和报价中心签约时约定的信息
        /// </summary>
        [JsonProperty("client_id")]
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 子协议扩展号，同一个客户不同业务场景下需要不同的客户报价，通过profile_id区分。正常情况下可能每个客户只有一个默认的profile_id
        /// </summary>
        [JsonProperty("profile_id")]
        [XmlElement("profile_id")]
        public string ProfileId { get; set; }
    }
}
