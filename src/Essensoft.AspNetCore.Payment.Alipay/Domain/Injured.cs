using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Injured Data Structure.
    /// </summary>
    [Serializable]
    public class Injured : AlipayObject
    {
        /// <summary>
        /// 姓名，须与证件上名称一致
        /// </summary>
        [JsonProperty("cert_name")]
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，  枚举：  IDENTITY_CARD：身份证  备注：目前仅支持身份证类型
        /// </summary>
        [JsonProperty("cert_type")]
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 人伤类型，枚举如下：  SCENE_SIMPLE:现场简易处理  CLINIC:门诊  IN_HOSPITAL:住院  MAIM:伤残  DEAD:死亡
        /// </summary>
        [JsonProperty("damage_type")]
        [XmlElement("damage_type")]
        public string DamageType { get; set; }

        /// <summary>
        /// 伤者身份：  PASSENGER:乘客  DRIVER:司机  THIRD:三者
        /// </summary>
        [JsonProperty("injured_identity")]
        [XmlElement("injured_identity")]
        public string InjuredIdentity { get; set; }

        /// <summary>
        /// 医疗定损员  核赔阶段必传
        /// </summary>
        [JsonProperty("medical_assessor")]
        [XmlElement("medical_assessor")]
        public Person MedicalAssessor { get; set; }

        /// <summary>
        /// 医疗查勘员信息
        /// </summary>
        [JsonProperty("medical_surveyor")]
        [XmlElement("medical_surveyor")]
        public Person MedicalSurveyor { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile_no")]
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }
    }
}
