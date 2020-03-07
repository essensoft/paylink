using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceKidsMsgSceneSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceKidsMsgSceneSendModel : AlipayObject
    {
        /// <summary>
        /// 业务码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// operator_name：刷脸行为人，如学生或教职工，必填；school_name：学校名称，必填；school_stdcode：学校外标，必填；link：如alipays://platformapi/startapp?appId=xxxx，必填；memo：备注信息，必填；target_userid：消息接入人uid，必填；operator_userid：刷脸行为人UID，必填； contact_info：联系信息，必填；
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 业务真实发生时间，如核身时间点，消费支付时间点。格式要求yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 外部业务唯一编号，重复报错
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务类型，确定数据使用场景。就餐提醒：school_facepay、离校提醒：school_entrance_out、入校提醒：school_entrance_in，考勤提醒：school_sign
        /// </summary>
        [JsonPropertyName("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板版本号，默认为1.0
        /// </summary>
        [JsonPropertyName("template_code_version")]
        public string TemplateCodeVersion { get; set; }
    }
}
