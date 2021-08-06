using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignOrderVoucherConsultModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignOrderVoucherConsultModel : AlipayObject
    {
        /// <summary>
        /// 商品咨询请求列表（当需要咨询单品券时必传，如果某商品不希望参与本次单品优惠咨询则不传递对应信息即可）
        /// </summary>
        [JsonPropertyName("item_consult_list")]
        public List<ItemConsultRequest> ItemConsultList { get; set; }

        /// <summary>
        /// 订单金额（如同时享受商户自有优惠请先扣除后传入），单位为元，最多2位小数
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 场景码：默认(DEFAULT)
        /// </summary>
        [JsonPropertyName("scene_code")]
        public List<string> SceneCode { get; set; }

        /// <summary>
        /// 券指定的核销appid（如果配券时指定了核销范围为线上小程序及相应的appid则此处必传）
        /// </summary>
        [JsonPropertyName("specified_app_id")]
        public string SpecifiedAppId { get; set; }
    }
}
