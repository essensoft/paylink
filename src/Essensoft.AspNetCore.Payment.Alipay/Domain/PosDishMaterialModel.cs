using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishMaterialModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishMaterialModel : AlipayObject
    {
        /// <summary>
        /// 配菜的ID
        /// </summary>
        [JsonProperty("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配菜的名字
        /// </summary>
        [JsonProperty("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 配菜的价格
        /// </summary>
        [JsonProperty("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 配料的排序号，新建，更新都是必传的
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }
    }
}
