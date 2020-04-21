using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceKidsAccountBindModel Data Structure.
    /// </summary>
    public class AlipayCommerceKidsAccountBindModel : AlipayObject
    {
        /// <summary>
        /// 与child_cert_type对应，如果child_cert_type为IDENTITY_CARD，对应的取值为身份证号
        /// </summary>
        [JsonPropertyName("child_cert_no")]
        public string ChildCertNo { get; set; }

        /// <summary>
        /// 证件类型，暂时只支持身份证
        /// </summary>
        [JsonPropertyName("child_cert_type")]
        public string ChildCertType { get; set; }

        /// <summary>
        /// 儿童唯一id
        /// </summary>
        [JsonPropertyName("child_id")]
        public string ChildId { get; set; }

        /// <summary>
        /// 儿童名字
        /// </summary>
        [JsonPropertyName("child_name")]
        public string ChildName { get; set; }

        /// <summary>
        /// 所在班级
        /// </summary>
        [JsonPropertyName("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 联系人手机
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 家长支付宝userId，创建的账户将会同时与家长绑定关系
        /// </summary>
        [JsonPropertyName("parent_uid")]
        public string ParentUid { get; set; }

        /// <summary>
        /// 场景码，接入前需要进行申请
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 学校id，建议采用支付宝分配的学校编号
        /// </summary>
        [JsonPropertyName("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [JsonPropertyName("student_no")]
        public string StudentNo { get; set; }
    }
}
