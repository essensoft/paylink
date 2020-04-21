using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMessageDeliverModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataMessageDeliverModel : AlipayObject
    {
        /// <summary>
        /// 消息内容，json格式， KEY值编号递增
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展信息， json格式，  key值：  REDIRECT_URL跳转地址;   CHANNEL发送渠道，对应value值为：MSGBOX消息盒子，PUSH手机消息通知
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 消息业务类型  活动推荐消息：PROMO_RECOMMEND;  活动效果消息: PROMO_STAT
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }
    }
}
