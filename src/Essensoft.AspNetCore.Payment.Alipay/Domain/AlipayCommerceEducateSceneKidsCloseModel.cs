using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneKidsCloseModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateSceneKidsCloseModel : AlipayObject
    {
        /// <summary>
        /// 业务场景码，SCHOOL_PAYMENT：校园支付，STUDENT_CARD：电子学生卡
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 扩展参数：当bizCode是SCHOOL_PAYMENT，cert_type,cert_no必传，当sub_biz_code是SCHOOL_PAYMENT_FACEPAY，agreement_no必传;
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 接口调用id，需保证唯一做幂等
        /// </summary>
        [JsonPropertyName("invoke_id")]
        public string InvokeId { get; set; }

        /// <summary>
        /// 备注，可注明业务场景或特殊说明
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 家长uid
        /// </summary>
        [JsonPropertyName("parent_uid")]
        public string ParentUid { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 子业务码，SCHOOL_PAYMENT_ENTRANCE：核身，SCHOOL_PAYMENT_FACEPAY：刷脸支付， SCHOOL_PAYMENT_FACEPAY_BANK：刷脸支付（指定银行卡）
        /// </summary>
        [JsonPropertyName("sub_biz_code")]
        public string SubBizCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
