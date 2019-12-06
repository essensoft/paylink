using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndustryQualificationInfo Data Structure.
    /// </summary>
    public class IndustryQualificationInfo : AlipayObject
    {
        /// <summary>
        /// 商户行业资质图片。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key
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
