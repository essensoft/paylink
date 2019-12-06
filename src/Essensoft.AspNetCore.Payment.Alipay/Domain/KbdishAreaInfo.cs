using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishAreaInfo Data Structure.
    /// </summary>
    public class KbdishAreaInfo : AlipayObject
    {
        /// <summary>
        /// 餐区开台菜列表
        /// </summary>
        [JsonPropertyName("area_free_list")]
        public List<KbdishAreaFreeInfo> AreaFreeList { get; set; }

        /// <summary>
        /// 餐区id
        /// </summary>
        [JsonPropertyName("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐区名称
        /// </summary>
        [JsonPropertyName("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 餐区排序序号
        /// </summary>
        [JsonPropertyName("area_sort")]
        public string AreaSort { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 餐区服务费
        /// </summary>
        [JsonPropertyName("fee_price")]
        public string FeePrice { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店id 支付宝的
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 餐区的餐桌数量
        /// </summary>
        [JsonPropertyName("tab_count")]
        public string TabCount { get; set; }

        /// <summary>
        /// 餐区下的餐台列表
        /// </summary>
        [JsonPropertyName("tab_list")]
        public List<KbdishTabInfo> TabList { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
