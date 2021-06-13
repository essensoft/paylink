using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PickUpInfo Data Structure.
    /// </summary>
    public class PickUpInfo : AlipayObject
    {
        /// <summary>
        /// 自提地址（展示的地址）
        /// </summary>
        [JsonPropertyName("pick_up_address")]
        public string PickUpAddress { get; set; }

        /// <summary>
        /// 类型对应取餐码，待自取及之后状态必填。建议生成该字段时即回传。
        /// </summary>
        [JsonPropertyName("pick_up_code")]
        public string PickUpCode { get; set; }

        /// <summary>
        /// 自提门店名称
        /// </summary>
        [JsonPropertyName("pick_up_shop_name")]
        public string PickUpShopName { get; set; }

        /// <summary>
        /// 取餐凭证类型。待自取及之后状态必填。整体状态生命周期中，必须回传1次。枚举支持：自提码-SELF_PICK_CODE ；口令-PASSWORD。
        /// </summary>
        [JsonPropertyName("pick_up_type")]
        public string PickUpType { get; set; }
    }
}
