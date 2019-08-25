using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneTokenCreateModel : AlipayObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 1:身份证  2:军官证  3:士兵证  8:台湾居民通行证  A:护照  B:户口簿  Z:其它证件
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 采集人员的支付宝会员标识
        /// </summary>
        [JsonProperty("operator_user_id")]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 家长手机号码
        /// </summary>
        [JsonProperty("parent_phone")]
        public string ParentPhone { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [JsonProperty("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [JsonProperty("student_name")]
        public string StudentName { get; set; }

        /// <summary>
        /// 教育场景子业务
        /// </summary>
        [JsonProperty("sub_code")]
        public string SubCode { get; set; }
    }
}
