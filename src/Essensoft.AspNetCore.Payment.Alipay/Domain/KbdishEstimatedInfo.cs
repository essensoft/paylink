using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishEstimatedInfo Data Structure.
    /// </summary>
    public class KbdishEstimatedInfo : AlipayObject
    {
        /// <summary>
        /// 估清的菜品dishid，加料materialId，或者外部菜品id，该值对应的类型由dsType指定。
        /// </summary>
        [JsonPropertyName("ds_id")]
        public string DsId { get; set; }

        /// <summary>
        /// dishid:菜品维度估清 materialid:加料维度沽清 outdishid:外部菜品id估清，使用外部菜品id需要特殊权限，请联系技术支持
        /// </summary>
        [JsonPropertyName("ds_type")]
        public string DsType { get; set; }

        /// <summary>
        /// 估清后临时库存.大于等于0的数字。 在沽清类型为加料的时候，该项强制为0。
        /// </summary>
        [JsonPropertyName("inventory")]
        public string Inventory { get; set; }

        /// <summary>
        /// 外部门店id，与shop_id不能同时为空 使用外部门店id需要特殊申请，请联系技术支持
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 口碑门店ID，使用out_shop_id时可以为空
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 状态。open:估清;stop:取消估清
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 估清最后修改人
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
