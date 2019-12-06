using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoteDateModel Data Structure.
    /// </summary>
    public class PromoteDateModel : AlipayObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 推广数据
        /// </summary>
        [JsonPropertyName("promote_data")]
        public PromoteDataModel PromoteData { get; set; }
    }
}
