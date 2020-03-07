using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
