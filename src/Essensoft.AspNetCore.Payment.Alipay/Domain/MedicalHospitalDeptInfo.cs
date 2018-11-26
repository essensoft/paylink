using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MedicalHospitalDeptInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHospitalDeptInfo : AlipayObject
    {
        /// <summary>
        /// 科室唯一标识，编码开发者生成并保证唯一
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 科室位置
        /// </summary>
        [JsonProperty("location")]
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父科室名称 如果是顶层科室可空 目的定位科室级联关系
        /// </summary>
        [JsonProperty("parent_name")]
        [XmlElement("parent_name")]
        public string ParentName { get; set; }

        /// <summary>
        /// 父科室唯一标识  如果是顶层科室可空  目的定位科室级联关系
        /// </summary>
        [JsonProperty("partner_code")]
        [XmlElement("partner_code")]
        public string PartnerCode { get; set; }
    }
}
