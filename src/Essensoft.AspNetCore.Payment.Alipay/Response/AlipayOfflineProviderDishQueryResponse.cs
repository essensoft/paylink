using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineProviderDishQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderDishQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 总共有多少条菜品信息。可用于计算分页。
        /// </summary>
        [JsonProperty("items")]
        [XmlElement("items")]
        public long Items { get; set; }

        /// <summary>
        /// 菜品列表信息
        /// </summary>
        [JsonProperty("list")]
        [XmlArray("list")]
        [XmlArrayItem("isv_shop_dish_model")]
        public List<IsvShopDishModel> List { get; set; }

        /// <summary>
        /// 当前数据所在的页码数
        /// </summary>
        [JsonProperty("page")]
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 当前查询结果分页的条数，可用于计算分页
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 当前条件下查询结果总的页码数
        /// </summary>
        [JsonProperty("pages")]
        [XmlElement("pages")]
        public long Pages { get; set; }
    }
}
