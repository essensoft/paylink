using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoteDateModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteDateModel : AlipayObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 推广数据
        /// </summary>
        [JsonProperty("promote_data")]
        public PromoteDataModel PromoteData { get; set; }
    }
}
