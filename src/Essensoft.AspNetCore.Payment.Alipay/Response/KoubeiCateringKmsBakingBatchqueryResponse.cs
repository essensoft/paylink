using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringKmsBakingBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringKmsBakingBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 烘焙商品销量预测
        /// </summary>
        [JsonPropertyName("baking_sales_forecast_data")]
        public List<KmsBakingSalesForecastDTO> BakingSalesForecastData { get; set; }
    }
}
