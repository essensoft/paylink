using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NetFlowDeviceOfferInfoResponse Data Structure.
    /// </summary>
    public class NetFlowDeviceOfferInfoResponse : AlipayObject
    {
        /// <summary>
        /// 物联网卡卡状态
        /// </summary>
        [JsonPropertyName("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 流量到期时间
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 流量充值记录信息
        /// </summary>
        [JsonPropertyName("net_flow_offer_info_list")]
        public NetFlowOfferInfo NetFlowOfferInfoList { get; set; }

        /// <summary>
        /// 充值金额描述
        /// </summary>
        [JsonPropertyName("offer_amount")]
        public string OfferAmount { get; set; }

        /// <summary>
        /// 充值商品地址
        /// </summary>
        [JsonPropertyName("offer_url")]
        public string OfferUrl { get; set; }
    }
}
