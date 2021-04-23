using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateScenePhotoremoteApplyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateScenePhotoremoteApplyModel : AlipayObject
    {
        /// <summary>
        /// 证件号。
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。{1:身份证，A:护照}
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 学生上半身照片的Base64编码。（注：1.图片的格式必须是jpg的；2.图片大小不超过125KB；3.非Data URI格式，请直接返回原文件的base64编码）
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// 外部照片Id。（注：用于关联当前提交的学生信息。如果同一个学生尝试重新提交，请务必生成新的id）
        /// </summary>
        [JsonPropertyName("out_photo_id")]
        public string OutPhotoId { get; set; }

        /// <summary>
        /// 学生家长支付宝账号绑定的手机号。
        /// </summary>
        [JsonPropertyName("parent_phone_number")]
        public string ParentPhoneNumber { get; set; }

        /// <summary>
        /// 学校外标（即学校的统一信用编码）。（注：若您不知道学校的统一信用编码，请联系对应的业务/产品咨询）
        /// </summary>
        [JsonPropertyName("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学生姓名。
        /// </summary>
        [JsonPropertyName("student_name")]
        public string StudentName { get; set; }
    }
}
