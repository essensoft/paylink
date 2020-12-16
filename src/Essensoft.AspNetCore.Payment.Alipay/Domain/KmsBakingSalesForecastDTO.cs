using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KmsBakingSalesForecastDTO Data Structure.
    /// </summary>
    public class KmsBakingSalesForecastDTO : AlipayObject
    {
        /// <summary>
        /// 预测日期
        /// </summary>
        [JsonPropertyName("forecast_date")]
        public string ForecastDate { get; set; }

        /// <summary>
        /// 预测级别预测分为5个等级 A、B、C、D、E（不可预测） 1、E（不可预测）：当sku的历史数据小于等于14条，不进行预测，提示数据量较少，无法进行预测。T+1，T+2，T+3均为空。 2、D：当sku的历史数据大于14条，小于等于60条。只有库存数据为D-；有营销数据为D； 3、C：当sku的历史数据大于60条，小于等于180条。只有库存数据为C-；有营销库存数据为C； 4、B：当sku的历史数据大于180条，小于等于400条。只有库存数据为B-；有营销数据为B； 5、A：当sku的历史数据大于400条。只有库存数据为A-；有营销o数据为A；
        /// </summary>
        [JsonPropertyName("forecast_level")]
        public string ForecastLevel { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// t+1日预测数据
        /// </summary>
        [JsonPropertyName("t_plus_one")]
        public string TPlusOne { get; set; }

        /// <summary>
        /// t+3日预测数据
        /// </summary>
        [JsonPropertyName("t_plus_three")]
        public string TPlusThree { get; set; }

        /// <summary>
        /// t+2日预测数据
        /// </summary>
        [JsonPropertyName("t_plus_two")]
        public string TPlusTwo { get; set; }
    }
}
