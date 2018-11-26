using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthousePublicrentApplyscheduleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthousePublicrentApplyscheduleSyncModel : AlipayObject
    {
        /// <summary>
        /// 申请单进度列表
        /// </summary>
        [JsonProperty("apply_schedule_list")]
        [XmlArray("apply_schedule_list")]
        [XmlArrayItem("eco_apply_schedule")]
        public List<EcoApplySchedule> ApplyScheduleList { get; set; }

        /// <summary>
        /// 证件号-身份证号
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 租客用户Id
        /// </summary>
        [JsonProperty("rent_id")]
        [XmlElement("rent_id")]
        public string RentId { get; set; }
    }
}
