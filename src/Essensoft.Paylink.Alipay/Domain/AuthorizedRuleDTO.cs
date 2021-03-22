using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AuthorizedRuleDTO Data Structure.
    /// </summary>
    public class AuthorizedRuleDTO : AlipayObject
    {
        /// <summary>
        /// 授权商户列表
        /// </summary>
        [JsonPropertyName("authorized_detail_list")]
        public List<AuthorizeDetailDTO> AuthorizedDetailList { get; set; }

        /// <summary>
        /// WHITELIST-白名单 ALL-全部
        /// </summary>
        [JsonPropertyName("authorized_type")]
        public string AuthorizedType { get; set; }
    }
}
