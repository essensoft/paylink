using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelShopFollowModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelShopFollowModel : AlipayObject
    {
        /// <summary>
        /// 取值说明：CONFIRM确认收藏/CANCEL取消收藏
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 多端统一渠道信息，与服务提供方协商分配，为空则默认取appId
        /// </summary>
        [JsonPropertyName("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 支付宝跨境游店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 请求唯一id，只能是大小写字母及数字。不带业务含义，可以由uuid等随机生成，用于唯一标识一笔业务，方便与外部排查问题
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 用户id，与user_id_type配合使用，暂时仅支持集团havanaId和支付宝2088开头的16位数字ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id类型枚举，与user_id配合使用。取值说明：HAVANA为集团havanaId，ALIPAY为支付宝2088开头用户id。不传的时候，默认为ALIPAY。
        /// </summary>
        [JsonPropertyName("user_id_type")]
        public string UserIdType { get; set; }
    }
}
