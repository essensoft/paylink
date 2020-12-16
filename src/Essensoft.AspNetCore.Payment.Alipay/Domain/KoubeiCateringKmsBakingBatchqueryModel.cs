using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringKmsBakingBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringKmsBakingBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 预测日期，目前只支持预测当天日期
        /// </summary>
        [JsonPropertyName("forecast_date")]
        public string ForecastDate { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商品skuId，数组结构，目前批量最多只支持100个sku
        /// </summary>
        [JsonPropertyName("sku_id")]
        public List<string> SkuId { get; set; }
    }
}
