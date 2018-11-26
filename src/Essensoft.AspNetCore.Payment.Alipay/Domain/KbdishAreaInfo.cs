using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishAreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishAreaInfo : AlipayObject
    {
        /// <summary>
        /// 餐区开台菜列表
        /// </summary>
        [JsonProperty("area_free_list")]
        [XmlArray("area_free_list")]
        [XmlArrayItem("kbdish_area_free_info")]
        public List<KbdishAreaFreeInfo> AreaFreeList { get; set; }

        /// <summary>
        /// 餐区id
        /// </summary>
        [JsonProperty("area_id")]
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐区名称
        /// </summary>
        [JsonProperty("area_name")]
        [XmlElement("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 餐区排序序号
        /// </summary>
        [JsonProperty("area_sort")]
        [XmlElement("area_sort")]
        public string AreaSort { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("create_user")]
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 餐区服务费
        /// </summary>
        [JsonProperty("fee_price")]
        [XmlElement("fee_price")]
        public string FeePrice { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [JsonProperty("merchant_id")]
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店id 支付宝的
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 餐区的餐桌数量
        /// </summary>
        [JsonProperty("tab_count")]
        [XmlElement("tab_count")]
        public string TabCount { get; set; }

        /// <summary>
        /// 餐区下的餐台列表
        /// </summary>
        [JsonProperty("tab_list")]
        [XmlArray("tab_list")]
        [XmlArrayItem("kbdish_tab_info")]
        public List<KbdishTabInfo> TabList { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonProperty("update_user")]
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
