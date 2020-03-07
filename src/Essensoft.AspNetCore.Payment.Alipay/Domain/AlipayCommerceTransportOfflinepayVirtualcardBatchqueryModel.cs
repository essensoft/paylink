using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayVirtualcardBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayVirtualcardBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 卡号。和卡类型一起，唯一确定一张卡。为空时将返回该用户该卡类型下的所有卡。
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡类型。每种虚拟卡都有对应的卡类型，该值由支付宝分配给商户。
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 是否返回包含已删除卡片 false：不返回已删除卡片，默认值； true：返回已删除卡片
        /// </summary>
        [JsonPropertyName("include_deleted")]
        public bool IncludeDeleted { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
