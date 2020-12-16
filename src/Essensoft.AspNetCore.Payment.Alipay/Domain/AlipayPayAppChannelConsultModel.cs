using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayAppChannelConsultModel Data Structure.
    /// </summary>
    public class AlipayPayAppChannelConsultModel : AlipayObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务标识
        /// </summary>
        [JsonPropertyName("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 业务订单列表
        /// </summary>
        [JsonPropertyName("biz_order_list")]
        public List<BizOrderInfo> BizOrderList { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 全局扩展参数
        /// </summary>
        [JsonPropertyName("ext_params")]
        public BizExtInfo ExtParams { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
