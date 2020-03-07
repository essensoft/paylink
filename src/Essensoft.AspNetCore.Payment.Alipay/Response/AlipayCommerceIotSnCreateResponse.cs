using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotSnCreateResponse.
    /// </summary>
    public class AlipayCommerceIotSnCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单id，用于后续追踪或查询该批次的设备sn
        /// </summary>
        [JsonPropertyName("apply_id")]
        public long ApplyId { get; set; }

        /// <summary>
        /// 生成的sn列表
        /// </summary>
        [JsonPropertyName("sn_list")]
        public List<string> SnList { get; set; }
    }
}
