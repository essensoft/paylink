using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishMaterialModel Data Structure.
    /// </summary>
    public class PosDishMaterialModel : AlipayObject
    {
        /// <summary>
        /// 配菜的ID
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配菜的名字
        /// </summary>
        [JsonPropertyName("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 配菜的价格
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 配料的排序号，新建，更新都是必传的
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }
    }
}
