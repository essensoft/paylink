using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayEbppMerchantConfigGetResponse.
    /// </summary>
    public class AlipayEbppMerchantConfigGetResponse : AlipayResponse
    {
        /// <summary>
        /// 商户机构配置信息
        /// </summary>
        [JsonProperty("inst_configs")]
        public List<MerchantInstConfig> InstConfigs { get; set; }

        /// <summary>
        /// 商户的用户ID
        /// </summary>
        [JsonProperty("merchant_user_id")]
        public string MerchantUserId { get; set; }
    }
}
