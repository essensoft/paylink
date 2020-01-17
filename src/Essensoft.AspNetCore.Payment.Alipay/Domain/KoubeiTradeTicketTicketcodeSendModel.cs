using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeSendModel Data Structure.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeSendModel : AlipayObject
    {
        /// <summary>
        /// 需要发送的码列表，其中code表示串码码值，num表示码的可核销份数
        /// </summary>
        [JsonPropertyName("isv_ma_list")]
        public List<KbIsvMaCode> IsvMaList { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求id，唯一标识一次请求
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑商品发货单号
        /// </summary>
        [JsonPropertyName("send_order_no")]
        public string SendOrderNo { get; set; }

        /// <summary>
        /// 口碑发码通知透传码商，码商需要跟发码通知获取到的参数一致
        /// </summary>
        [JsonPropertyName("send_token")]
        public string SendToken { get; set; }

        /// <summary>
        /// 券过期时间,默认为口碑商品配置失效时间
        /// </summary>
        [JsonPropertyName("valid_end")]
        public string ValidEnd { get; set; }

        /// <summary>
        /// 券生效时间,默认为口碑商品配置生效时间
        /// </summary>
        [JsonPropertyName("valid_start")]
        public string ValidStart { get; set; }
    }
}
