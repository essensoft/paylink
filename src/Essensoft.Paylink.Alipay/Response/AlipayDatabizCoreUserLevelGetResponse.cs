using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDatabizCoreUserLevelGetResponse.
    /// </summary>
    public class AlipayDatabizCoreUserLevelGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户等级信息
        /// </summary>
        [JsonPropertyName("user_level_infos")]
        public List<AlipayUserLevelInfo> UserLevelInfos { get; set; }
    }
}
