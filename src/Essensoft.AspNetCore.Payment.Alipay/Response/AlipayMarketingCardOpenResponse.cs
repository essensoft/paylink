using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardOpenResponse.
    /// </summary>
    public class AlipayMarketingCardOpenResponse : AlipayResponse
    {
        /// <summary>
        /// 商户卡信息（包括支付宝分配的业务卡号）
        /// </summary>
        [JsonPropertyName("card_info")]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 实际记录的领卡渠道（可能跟商户传入值不同）；  可直接标识领卡渠道，也可配合open_card_channel_id标识领卡渠道类型：  例如：  线下门店领取:20161534000000000008863（直接标识领卡渠道，门店shopId）  线下扫二维码领取:QR（标识领卡类型）;  线下活动领取:20170522000000000003609（直接标识领卡渠道，商户活动ID）
        /// </summary>
        [JsonPropertyName("open_card_channel")]
        public string OpenCardChannel { get; set; }

        /// <summary>
        /// 实际记录的领卡来源渠道id（可能跟商户传入值不同）；  区别于open_card_channel领卡渠道；  一般使用场景：  open_card_channel用于区分渠道类型，例如取值为"SHOP"（门店），"ACTIVITY"（活动）；  则open_card_channel_id可用于区分同渠道的不同实体，对应取各门店ID或各活动的标识ID等；
        /// </summary>
        [JsonPropertyName("open_card_channel_id")]
        public string OpenCardChannelId { get; set; }
    }
}
