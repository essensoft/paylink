using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAntimarketcheatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskAntimarketcheatQueryModel : AlipayObject
    {
        /// <summary>
        /// 行为发生时的身份证号
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 调用服务的商户id ，如果是第三方服务商，需要将其实际的商户id透传过来，如果是普通商户传入自己的appid即可
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 行为发生时的手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 风险场景码
        /// </summary>
        [JsonProperty("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("sys_version")]
        public string SysVersion { get; set; }
    }
}
