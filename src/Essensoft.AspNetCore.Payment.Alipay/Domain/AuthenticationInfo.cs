using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthenticationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuthenticationInfo : AlipayObject
    {
        /// <summary>
        /// 身份认证场景信息
        /// </summary>
        [JsonProperty("authentication_scene")]
        [XmlElement("authentication_scene")]
        public AuthenticationScene AuthenticationScene { get; set; }

        /// <summary>
        /// 标识一笔业务，业务方生成
        /// </summary>
        [JsonProperty("biz_id")]
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonProperty("extend_info")]
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 身份认证业务用户主体信息
        /// </summary>
        [JsonProperty("principal_info")]
        [XmlElement("principal_info")]
        public PrincipalInfo PrincipalInfo { get; set; }
    }
}
