using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectTiansuoQueryModel : AlipayObject
    {
        /// <summary>
        /// 间连商户入驻时填写的营业执照号
        /// </summary>
        [JsonProperty("business_license_no")]
        public string BusinessLicenseNo { get; set; }
    }
}
