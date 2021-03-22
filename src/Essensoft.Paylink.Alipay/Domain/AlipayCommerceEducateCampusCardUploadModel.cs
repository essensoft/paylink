using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusCardUploadModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateCampusCardUploadModel : AlipayObject
    {
        /// <summary>
        /// 逐步废弃，请使用card_pictures字段！学生证照片链接(可多张)。注：需要提供图片oss URL访问地址，且url需要长期有效
        /// </summary>
        [JsonPropertyName("campus_card_picture")]
        public List<string> CampusCardPicture { get; set; }

        /// <summary>
        /// 学生证图片链接list，包含图片类型
        /// </summary>
        [JsonPropertyName("card_pictures")]
        public List<CampusCardPicture> CardPictures { get; set; }

        /// <summary>
        /// 学历，枚举类型：专科0，本科1，研究生2，博士3
        /// </summary>
        [JsonPropertyName("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 入学时间，格式yyyy-mm-dd，不传无法自动机器审核
        /// </summary>
        [JsonPropertyName("enroll_date")]
        public string EnrollDate { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }
    }
}
