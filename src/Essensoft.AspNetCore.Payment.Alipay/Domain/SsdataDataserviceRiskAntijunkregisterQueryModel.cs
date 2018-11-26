using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAntijunkregisterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskAntijunkregisterQueryModel : AlipayObject
    {
        /// <summary>
        /// 行为发生时的Apdid值
        /// </summary>
        [JsonProperty("apdid")]
        [XmlElement("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 行为发生时的IP值
        /// </summary>
        [JsonProperty("ip")]
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 调用服务的商户id ，如果是第三方服务商，需要将其实际的商户id透传过来，如果是普通商户传入自己的appid即可
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 行为发生时的手机号
        /// </summary>
        [JsonProperty("phone")]
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 风险场景码，不传该参数，则走默认的场景
        /// </summary>
        [JsonProperty("risk_code")]
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 业务场景，不传该参数，则走默认的业务场景
        /// </summary>
        [JsonProperty("scene_code")]
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("sys_version")]
        [XmlElement("sys_version")]
        public string SysVersion { get; set; }

        /// <summary>
        /// 行为发生时的UMID值
        /// </summary>
        [JsonProperty("umid")]
        [XmlElement("umid")]
        public string Umid { get; set; }
    }
}
