using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosStallModifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosStallModifyModel : AlipayObject
    {
        /// <summary>
        /// 菜品id列表
        /// </summary>
        [JsonPropertyName("dish_ids")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 档口id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonPropertyName("printer_id")]
        public string PrinterId { get; set; }

        /// <summary>
        /// 打印机类型（FRONT_DESK_PRINTER：前台打印机；LABEL_PRINTER：标签打印机；KITCHEN_PRINTER：厨房打印机）
        /// </summary>
        [JsonPropertyName("printer_type")]
        public string PrinterType { get; set; }

        /// <summary>
        /// 是否分单打印（"parted"："菜品分开打印"；"together"："菜品统一打印"）
        /// </summary>
        [JsonPropertyName("receipt_type")]
        public string ReceiptType { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 档口名称
        /// </summary>
        [JsonPropertyName("stall_name")]
        public string StallName { get; set; }

        /// <summary>
        /// 启用情况（false:停用；true:启用）
        /// </summary>
        [JsonPropertyName("use")]
        public bool Use { get; set; }
    }
}
