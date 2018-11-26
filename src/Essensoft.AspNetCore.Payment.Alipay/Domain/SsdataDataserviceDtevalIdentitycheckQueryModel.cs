using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceDtevalIdentitycheckQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceDtevalIdentitycheckQueryModel : AlipayObject
    {
        /// <summary>
        /// 工单流水号
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 采集到的身份证号
        /// </summary>
        [JsonProperty("col_cert_no")]
        [XmlElement("col_cert_no")]
        public string ColCertNo { get; set; }

        /// <summary>
        /// 采集到的手机号码
        /// </summary>
        [JsonProperty("col_mobile")]
        [XmlElement("col_mobile")]
        public string ColMobile { get; set; }

        /// <summary>
        /// 采集到的姓名
        /// </summary>
        [JsonProperty("col_user_name")]
        [XmlElement("col_user_name")]
        public string ColUserName { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [JsonProperty("ext_map")]
        [XmlElement("ext_map")]
        public string ExtMap { get; set; }

        /// <summary>
        /// 实际身份证号
        /// </summary>
        [JsonProperty("real_cert_no")]
        [XmlElement("real_cert_no")]
        public string RealCertNo { get; set; }

        /// <summary>
        /// 实际手机号号码
        /// </summary>
        [JsonProperty("real_mobile")]
        [XmlElement("real_mobile")]
        public string RealMobile { get; set; }

        /// <summary>
        /// 实际姓名
        /// </summary>
        [JsonProperty("real_user_name")]
        [XmlElement("real_user_name")]
        public string RealUserName { get; set; }
    }
}
