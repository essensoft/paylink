using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishPracticeInfo Data Structure.
    /// </summary>
    public class KbdishPracticeInfo : AlipayObject
    {
        /// <summary>
        /// 口碑的菜品id
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 加价类型  add:直接加 multiply:乘以系数
        /// </summary>
        [JsonProperty("increase_mode")]
        public string IncreaseMode { get; set; }

        /// <summary>
        /// 加价金额
        /// </summary>
        [JsonProperty("increase_price")]
        public string IncreasePrice { get; set; }

        /// <summary>
        /// 做法名称
        /// </summary>
        [JsonProperty("practice_name")]
        public string PracticeName { get; set; }
    }
}
