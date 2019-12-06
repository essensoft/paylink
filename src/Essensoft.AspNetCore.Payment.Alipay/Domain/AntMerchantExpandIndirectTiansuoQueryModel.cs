using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectTiansuoQueryModel : AlipayObject
    {
        /// <summary>
        /// 间连商户入驻时填写的营业执照号
        /// </summary>
        [JsonPropertyName("business_license_no")]
        public string BusinessLicenseNo { get; set; }
    }
}
