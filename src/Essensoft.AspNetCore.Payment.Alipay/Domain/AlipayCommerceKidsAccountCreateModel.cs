using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceKidsAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceKidsAccountCreateModel : AlipayObject
    {
        /// <summary>
        /// 与child_cert_type对应，如果child_cert_type为IDENTITY_CARD，对应的取值为身份证号
        /// </summary>
        [JsonProperty("child_cert_no")]
        public string ChildCertNo { get; set; }

        /// <summary>
        /// 证件类型，暂时只支持身份证
        /// </summary>
        [JsonProperty("child_cert_type")]
        public string ChildCertType { get; set; }

        /// <summary>
        /// 儿童名字
        /// </summary>
        [JsonProperty("child_name")]
        public string ChildName { get; set; }

        /// <summary>
        /// 所在班级
        /// </summary>
        [JsonProperty("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 联系人手机
        /// </summary>
        [JsonProperty("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 第三方业务id，需保证唯一或者和业务类型组合保证唯一，用于关联上传到支付宝的数据，比如在智能设备场景通常使用硬件唯一id
        /// </summary>
        [JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 外围业务类型，有具体场景决定具体语义，比如智能设备场景表示设备型号
        /// </summary>
        [JsonProperty("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 家长支付宝userId，创建的账户将会同时与家长绑定关系
        /// </summary>
        [JsonProperty("parent_uid")]
        public string ParentUid { get; set; }

        /// <summary>
        /// 场景码，接入前需要进行申请
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 学校id，建议采用支付宝分配的学校编号
        /// </summary>
        [JsonProperty("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [JsonProperty("student_no")]
        public string StudentNo { get; set; }
    }
}
