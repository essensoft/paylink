using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndustryQualificationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryQualificationInfo : AlipayObject
    {
        /// <summary>
        /// 商户行业资质图片。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key
        /// </summary>
        [JsonProperty("industry_qualification_image")]
        [XmlElement("industry_qualification_image")]
        public string IndustryQualificationImage { get; set; }

        /// <summary>
        /// 商户行业资质类型，具体选值参见https://mif-pub.alipayobjects.com/QualificationType.xlsx
        /// </summary>
        [JsonProperty("industry_qualification_type")]
        [XmlElement("industry_qualification_type")]
        public string IndustryQualificationType { get; set; }
    }
}
