using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntpaasTokenidentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasTokenidentityQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务Id，如口碑小程序场景下，该业务Id设置为微信unionId
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }
    }
}
