using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPayeeBindDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPayeeBindDeleteModel : AlipayObject
    {
        /// <summary>
        /// 收款账号，需要解除绑定的收款支付宝账号，跟pid不要同时传
        /// </summary>
        [JsonProperty("login_id")]
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头的16位长度字符串，跟login_id不要同时传
        /// </summary>
        [JsonProperty("pid")]
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
