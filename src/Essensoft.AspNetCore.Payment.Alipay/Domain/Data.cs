using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Data Data Structure.
    /// </summary>
    [Serializable]
    public class Data : AlipayObject
    {
        /// <summary>
        /// 用户id列表
        /// </summary>
        [JsonProperty("user_id_list")]
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
