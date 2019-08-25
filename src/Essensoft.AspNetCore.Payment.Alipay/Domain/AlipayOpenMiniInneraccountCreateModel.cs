using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInneraccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInneraccountCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 外部业务主体ID
        /// </summary>
        [JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
