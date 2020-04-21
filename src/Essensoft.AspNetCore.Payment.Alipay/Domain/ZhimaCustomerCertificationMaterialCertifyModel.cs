using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerCertificationMaterialCertifyModel Data Structure.
    /// </summary>
    public class ZhimaCustomerCertificationMaterialCertifyModel : AlipayObject
    {
        /// <summary>
        /// 认证场景码，常用的场景码有：FACE_API，入参支持的认证场景码和商户签约的认证场景相关，详见芝麻认证快速接入文档
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 扩展业务参数，暂时没有用到，接口预留
        /// </summary>
        [JsonPropertyName("ext_biz_param")]
        public string ExtBizParam { get; set; }

        /// <summary>
        /// "identity_type":”CERT_INFO”，是指入参类型为证件信息。芝麻认证有很多认证场景（biz_code），不同认证认证场景（biz_code）支持的入参类型不同，详细请见芝麻认证快速接入文档里面的表格
        /// </summary>
        [JsonPropertyName("identity_param")]
        public string IdentityParam { get; set; }

        /// <summary>
        /// 芝麻平台服务商模式下的二级商户标识，如果是直连商户调用该接口，不需要设置
        /// </summary>
        [JsonPropertyName("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 认证过程中需要的认证材料，不同认证场景需要的材料不同，biz_code值为FACE_API时需要材料FACIAL_PICTURE_FRONT
        /// </summary>
        [JsonPropertyName("materials")]
        public string Materials { get; set; }

        /// <summary>
        /// 商户可选的一些设置
        /// </summary>
        [JsonPropertyName("merchant_config")]
        public string MerchantConfig { get; set; }

        /// <summary>
        /// 芝麻认证产品码，示例值为真实的产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，商户要保证其唯一性。值为32位长度的字母数字下划线组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段日期，结尾可以使用一个序列
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
