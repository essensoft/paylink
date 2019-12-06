using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainShopDeleteModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMaintainShopDeleteModel : AlipayObject
    {
        /// <summary>
        /// 外部门店编号（与shop_id二选一，不能都为空）
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 车主平台门店编号（与out_shop_id二选一，不能都为空）
        /// </summary>
        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }
    }
}
