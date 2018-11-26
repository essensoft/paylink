using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMemberDataOauthQueryResponse.
    /// </summary>
    public class KoubeiMemberDataOauthQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息, 目前保留未用
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonProperty("operator_id")]
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("operator_partner_id")]
        [XmlElement("operator_partner_id")]
        public string OperatorPartnerId { get; set; }

        /// <summary>
        /// 操作人身份，PROVIDER:服务商,PROVIDER_STAFF:服务商员工,MER:商户,MER_STAFF:商户员工,SALES:阿里销售小二
        /// </summary>
        [JsonProperty("operator_type")]
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }
    }
}
