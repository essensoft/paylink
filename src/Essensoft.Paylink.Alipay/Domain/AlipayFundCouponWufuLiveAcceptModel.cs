using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuLiveAcceptModel Data Structure.
    /// </summary>
    public class AlipayFundCouponWufuLiveAcceptModel : AlipayObject
    {
        /// <summary>
        /// 发卡类型：WAN_NENG_FU-万能福，SURPRISE_CARD-惊喜福卡
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("front_biz_no")]
        public string FrontBizNo { get; set; }

        /// <summary>
        /// 淘宝主播ID
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 淘宝用户ID
        /// </summary>
        [JsonPropertyName("taobao_id")]
        public string TaobaoId { get; set; }
    }
}
