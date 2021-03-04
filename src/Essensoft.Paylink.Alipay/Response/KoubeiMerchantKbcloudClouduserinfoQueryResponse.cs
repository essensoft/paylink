using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudClouduserinfoQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudClouduserinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑云主账号数据列表
        /// </summary>
        [JsonPropertyName("cloud_user_list")]
        public List<CloudUserInfo> CloudUserList { get; set; }
    }
}
