using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodVidGetModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodVidGetModel : AlipayObject
    {
        /// <summary>
        /// 支付宝版本号
        /// </summary>
        [JsonPropertyName("alipay_version")]
        public string AlipayVersion { get; set; }

        /// <summary>
        /// 人脸核身方式。在人脸识别场景才需要填写
        /// </summary>
        [JsonPropertyName("meta_info")]
        public string MetaInfo { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [JsonPropertyName("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 可以选择的是人脸识别（FACE）或者账密方式（PASSWORD）,不填写默认使用账密方式
        /// </summary>
        [JsonPropertyName("verify_type")]
        public string VerifyType { get; set; }
    }
}
