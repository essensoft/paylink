using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserUseridBymobileQueryResponse.
    /// </summary>
    public class AlipayUserUseridBymobileQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 绑定手机号对应的支付宝userId列表【注意：最多返回10个】
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
