using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndustryQualificationInfoKt Data Structure.
    /// </summary>
    public class IndustryQualificationInfoKt : AlipayObject
    {
        /// <summary>
        /// 商户行业资质图片URL，格式jpg、jpeg、png
        /// </summary>
        [JsonPropertyName("industry_qualification_image")]
        public string IndustryQualificationImage { get; set; }

        /// <summary>
        /// 商户行业资质类型，具体选值参见https://mif-pub.alipayobjects.com/QualificationType.xlsx
        /// </summary>
        [JsonPropertyName("industry_qualification_type")]
        public string IndustryQualificationType { get; set; }
    }
}
