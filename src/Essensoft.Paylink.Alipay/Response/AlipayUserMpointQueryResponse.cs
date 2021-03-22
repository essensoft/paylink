using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserMpointQueryResponse.
    /// </summary>
    public class AlipayUserMpointQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户的蚂蚁会员积分余额
        /// </summary>
        [JsonPropertyName("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 支付宝用户的蚂蚁会员等级
        /// </summary>
        [JsonPropertyName("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 会员的联名信息，简单枚举值
        /// </summary>
        [JsonPropertyName("joint_info")]
        public List<string> JointInfo { get; set; }
    }
}
