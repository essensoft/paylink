using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BeikeAccountResponse Data Structure.
    /// </summary>
    public class BeikeAccountResponse : AlipayObject
    {
        /// <summary>
        /// 当前操作变化值
        /// </summary>
        [JsonPropertyName("change_amount")]
        public long ChangeAmount { get; set; }

        /// <summary>
        /// 呗壳当前用户所有的免息额度值，long类型
        /// </summary>
        [JsonPropertyName("current_amount")]
        public long CurrentAmount { get; set; }

        /// <summary>
        /// 外部唯一单号
        /// </summary>
        [JsonPropertyName("outer_biz_no")]
        public string OuterBizNo { get; set; }
    }
}
