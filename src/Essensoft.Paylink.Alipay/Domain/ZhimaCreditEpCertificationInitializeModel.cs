using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpCertificationInitializeModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpCertificationInitializeModel : AlipayObject
    {
        /// <summary>
        /// 认证类别，由蚂蚁企业信用方分发提供，配置有误会返回参数错误
        /// </summary>
        [JsonPropertyName("certify_category")]
        public string CertifyCategory { get; set; }

        /// <summary>
        /// 使用蚂蚁企业信用认证服务后，回跳到该商户指定的地址
        /// </summary>
        [JsonPropertyName("certify_return_url")]
        public string CertifyReturnUrl { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [JsonPropertyName("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [JsonPropertyName("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 商户唯一业务流水号，由大小写字母和数字构成
        /// </summary>
        [JsonPropertyName("org_biz_no")]
        public string OrgBizNo { get; set; }

        /// <summary>
        /// 产品码，请填写示例值里提供的值
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 证件号码，仅支持身份证号
        /// </summary>
        [JsonPropertyName("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 个人用户姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
