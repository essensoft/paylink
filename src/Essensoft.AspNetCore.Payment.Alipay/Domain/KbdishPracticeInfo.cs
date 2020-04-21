using System.Text.Json.Serialization;

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
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 加价类型  add:直接加
        /// </summary>
        [JsonPropertyName("increase_mode")]
        public string IncreaseMode { get; set; }

        /// <summary>
        /// 加价金额
        /// </summary>
        [JsonPropertyName("increase_price")]
        public string IncreasePrice { get; set; }

        /// <summary>
        /// 做法名称
        /// </summary>
        [JsonPropertyName("practice_name")]
        public string PracticeName { get; set; }
    }
}
