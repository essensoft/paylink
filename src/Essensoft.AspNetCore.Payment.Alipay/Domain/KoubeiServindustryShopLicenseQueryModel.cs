using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryShopLicenseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryShopLicenseQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }
    }
}
