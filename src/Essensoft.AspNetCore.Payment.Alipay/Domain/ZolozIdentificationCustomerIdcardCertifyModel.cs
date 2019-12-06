using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerIdcardCertifyModel Data Structure.
    /// </summary>
    public class ZolozIdentificationCustomerIdcardCertifyModel : AlipayObject
    {
        /// <summary>
        /// 业务唯一id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 当使用手填信息审核接口对营业执照进行审核时，填写该字段信息
        /// </summary>
        [JsonPropertyName("business_license_cert")]
        public BusinessLicenseCertFileds BusinessLicenseCert { get; set; }

        /// <summary>
        /// 当使用手填信息审核接口对身份证进行审核时，填写该字段信息
        /// </summary>
        [JsonPropertyName("cert")]
        public CertFields Cert { get; set; }

        /// <summary>
        /// 上传证件图片信息
        /// </summary>
        [JsonPropertyName("idcard_img")]
        public IdCardImg IdcardImg { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [JsonPropertyName("operater_id")]
        public string OperaterId { get; set; }
    }
}
