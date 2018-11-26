using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerCertificationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 认证的主体属性信息，一般的认证场景都是返回空
        /// </summary>
        [JsonProperty("attribute_info")]
        [XmlElement("attribute_info")]
        public string AttributeInfo { get; set; }

        /// <summary>
        /// 包含了认证过程中的认证材料和过程记录
        /// </summary>
        [JsonProperty("channel_statuses")]
        [XmlElement("channel_statuses")]
        public string ChannelStatuses { get; set; }

        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [JsonProperty("failed_reason")]
        [XmlElement("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证的主体信息，一般的认证场景返回为空
        /// </summary>
        [JsonProperty("identity_info")]
        [XmlElement("identity_info")]
        public string IdentityInfo { get; set; }

        /// <summary>
        /// 认证是否通过,通过为true，不通过为false
        /// </summary>
        [JsonProperty("passed")]
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
