using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishPracticeModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishPracticeModel : AlipayObject
    {
        /// <summary>
        /// 加价类型 add 加法  如果有做法，必传
        /// </summary>
        [JsonProperty("increase_mode")]
        public string IncreaseMode { get; set; }

        /// <summary>
        /// 加价价格，如果有做法必传
        /// </summary>
        [JsonProperty("increase_price")]
        public string IncreasePrice { get; set; }

        /// <summary>
        /// 做法的ID，如果有做法，必传
        /// </summary>
        [JsonProperty("practice_id")]
        public string PracticeId { get; set; }

        /// <summary>
        /// 做法的名字
        /// </summary>
        [JsonProperty("practice_name")]
        public string PracticeName { get; set; }

        /// <summary>
        /// 做法的排序字段
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }
    }
}
