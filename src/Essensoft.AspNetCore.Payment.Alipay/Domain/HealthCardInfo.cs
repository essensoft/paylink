using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HealthCardInfo Data Structure.
    /// </summary>
    public class HealthCardInfo : AlipayObject
    {
        /// <summary>
        /// 用户真实健康卡数据信息
        /// </summary>
        [JsonPropertyName("cards")]
        public List<HealthCard> Cards { get; set; }

        /// <summary>
        /// 支付宝内用户健康卡领取跳转地址链接，仅在用户没有健康卡数据是返回
        /// </summary>
        [JsonPropertyName("receive_url")]
        public string ReceiveUrl { get; set; }
    }
}
