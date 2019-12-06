using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StallKdsEntity Data Structure.
    /// </summary>
    public class StallKdsEntity : AlipayObject
    {
        /// <summary>
        /// 订单来源 枚举 默认all
        /// </summary>
        [JsonPropertyName("dinner_type")]
        public string DinnerType { get; set; }

        /// <summary>
        /// kds id
        /// </summary>
        [JsonPropertyName("kds_id")]
        public string KdsId { get; set; }

        /// <summary>
        /// kds名称
        /// </summary>
        [JsonPropertyName("kds_name")]
        public string KdsName { get; set; }

        /// <summary>
        /// kds类型 ： 制作屏，备餐屏 ， 取餐屏
        /// </summary>
        [JsonPropertyName("kds_type")]
        public string KdsType { get; set; }

        /// <summary>
        /// 0-不打印 ，1-打印 ， 默认 0
        /// </summary>
        [JsonPropertyName("print_flag")]
        public string PrintFlag { get; set; }

        /// <summary>
        /// 打印机 Id
        /// </summary>
        [JsonPropertyName("printer_id")]
        public string PrinterId { get; set; }
    }
}
