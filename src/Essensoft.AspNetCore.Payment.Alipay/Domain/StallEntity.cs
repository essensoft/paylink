using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StallEntity Data Structure.
    /// </summary>
    [Serializable]
    public class StallEntity : AlipayObject
    {
        /// <summary>
        /// 档口下菜品集合
        /// </summary>
        [JsonProperty("dish_ids")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 档口id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 档口和kds的绑定信息
        /// </summary>
        [JsonProperty("kds_list")]
        public List<StallKdsEntity> KdsList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonProperty("printer_id")]
        public string PrinterId { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [JsonProperty("printer_name")]
        public string PrinterName { get; set; }

        /// <summary>
        /// 打印机类型（FRONT_DESK_PRINTER：前台打印机；LABEL_PRINTER：标签打印机；KITCHEN_PRINTER：厨房打印机）
        /// </summary>
        [JsonProperty("printer_type")]
        public string PrinterType { get; set; }

        /// <summary>
        /// 是否分单打印（parted：菜品分开打印；together：菜品统一打印）
        /// </summary>
        [JsonProperty("receipt_type")]
        public string ReceiptType { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 档口名称
        /// </summary>
        [JsonProperty("stall_name")]
        public string StallName { get; set; }

        /// <summary>
        /// 启用情况（false:停用；true:启用）
        /// </summary>
        [JsonProperty("use")]
        public bool Use { get; set; }
    }
}
