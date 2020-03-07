using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceConsumRatioQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceConsumRatioQueryModel : AlipayObject
    {
        /// <summary>
        /// 区域编码，多个编码的时候用英文逗号分割，最多不超过20个
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域类型，枚举值：city(城市)、county(区县)、town(街道)、trading(商圈)
        /// </summary>
        [JsonPropertyName("area_type")]
        public string AreaType { get; set; }

        /// <summary>
        /// 数据类型，枚举值：dist(来源地占比)、gender(性别占比)、capacity(消费能力占比)、age(年龄占比)
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 查询占比的结束日期，格式为：4位年+2位月，最晚为当前月的上一月
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 查询指数的开始日期，格式为：4位年+2位月，最早为近6个月的开始月
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
