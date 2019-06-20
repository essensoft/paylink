using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarFuellingShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarFuellingShopQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部门店编号系统唯一，该值添加后不可修改，与字段shop_id不能同时为空
        /// </summary>
        [JsonProperty("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 车主平台内部门店编号，系统唯一,与字段out_shop_id不能同时为空
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
