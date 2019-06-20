using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantModel Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantModel : AlipayObject
    {
        /// <summary>
        /// 商户别名
        /// </summary>
        [JsonProperty("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户或者isv的pid
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
