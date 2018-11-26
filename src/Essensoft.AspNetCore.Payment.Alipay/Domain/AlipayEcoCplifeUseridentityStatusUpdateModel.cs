using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeUseridentityStatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeUseridentityStatusUpdateModel : AlipayObject
    {
        /// <summary>
        /// 业务明细
        /// </summary>
        [JsonProperty("biz_details")]
        [XmlElement("biz_details")]
        public string BizDetails { get; set; }

        /// <summary>
        /// 当前业务状态
        /// </summary>
        [JsonProperty("biz_state")]
        [XmlElement("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 业务单据ID
        /// </summary>
        [JsonProperty("req_id")]
        [XmlElement("req_id")]
        public string ReqId { get; set; }
    }
}
