using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceKidsAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceKidsAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 登陆名
        /// </summary>
        [JsonProperty("login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }
    }
}
