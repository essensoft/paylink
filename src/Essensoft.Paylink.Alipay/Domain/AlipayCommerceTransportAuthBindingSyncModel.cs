using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAuthBindingSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAuthBindingSyncModel : AlipayObject
    {
        /// <summary>
        /// 同步动作类型。取值bind、unbind。表示绑定和取消绑定
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权场景
        /// </summary>
        [JsonPropertyName("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
