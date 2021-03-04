using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
