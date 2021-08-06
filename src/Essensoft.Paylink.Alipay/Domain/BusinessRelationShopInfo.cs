using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BusinessRelationShopInfo Data Structure.
    /// </summary>
    public class BusinessRelationShopInfo : AlipayObject
    {
        /// <summary>
        /// 基于商业关系的代运营门店id
        /// </summary>
        [JsonPropertyName("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 外部门店编号，用于ISV系统内部门店标识等
        /// </summary>
        [JsonPropertyName("real_shop_no")]
        public string RealShopNo { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code。类目标准及与原类目映射关系参见 支付宝门店类目-最新 表格。
        /// </summary>
        [JsonPropertyName("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 代运营商业关系门店名称，即当前组织下可运营门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }
    }
}
