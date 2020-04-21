using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardOpenModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardOpenModel : AlipayObject
    {
        /// <summary>
        /// 外部卡信息(biz_card_no无需填写)
        /// </summary>
        [JsonPropertyName("card_ext_info")]
        public MerchantCard CardExtInfo { get; set; }

        /// <summary>
        /// 支付宝分配的卡模板Id（卡模板创建接口返回的模板ID）
        /// </summary>
        [JsonPropertyName("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 发卡用户信息
        /// </summary>
        [JsonPropertyName("card_user_info")]
        public CardUserInfo CardUserInfo { get; set; }

        /// <summary>
        /// 商户会员信息
        /// </summary>
        [JsonPropertyName("member_ext_info")]
        public MerchantMenber MemberExtInfo { get; set; }

        /// <summary>
        /// 领卡渠道，用于记录外部商户端领卡来源的渠道信息，渠道值可自行定义（仅限数字、字母、下划线）   可直接标识领卡渠道，也可配合open_card_channel_id标识领卡渠道类型：  例如：  线下门店领取:20161534000000000008863（直接标识领卡渠道，门店shopId）  线下扫二维码领取:QR（标识领卡类型）;  线下活动领取:20170522000000000003609（直接标识领卡渠道，商户活动ID）
        /// </summary>
        [JsonPropertyName("open_card_channel")]
        public string OpenCardChannel { get; set; }

        /// <summary>
        /// 领卡来源的渠道id，注意区别于open_card_channel领卡渠道；  一般使用场景：  open_card_channel用于区分渠道类型，例如取值为"SHOP"（门店），"ACTIVITY"（活动）；  则open_card_channel_id可用于区分同渠道的不同实体，对应取各门店ID或各活动的标识ID等；
        /// </summary>
        [JsonPropertyName("open_card_channel_id")]
        public string OpenCardChannelId { get; set; }

        /// <summary>
        /// 外部商户流水号（商户需要确保唯一性控制，类似request_id唯一请求标识）
        /// </summary>
        [JsonPropertyName("out_serial_no")]
        public string OutSerialNo { get; set; }
    }
}
