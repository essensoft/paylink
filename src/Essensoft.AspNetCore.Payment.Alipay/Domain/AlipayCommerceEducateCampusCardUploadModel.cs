using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusCardUploadModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateCampusCardUploadModel : AlipayObject
    {
        /// <summary>
        /// 学生证照片链接(可多张)。注：需要提供图片oss URL访问地址，且url需要长期有效
        /// </summary>
        [JsonPropertyName("campus_card_picture")]
        public List<string> CampusCardPicture { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }
    }
}
