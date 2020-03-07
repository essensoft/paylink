using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneEquityInstpointPrizeQueryModel Data Structure.
    /// </summary>
    public class AntfortuneEquityInstpointPrizeQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页数，取值[1,50]整数
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小，取值[1,20]整数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
