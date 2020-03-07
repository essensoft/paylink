using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsSellerActivity Data Structure.
    /// </summary>
    public class InsSellerActivity : AlipayObject
    {
        /// <summary>
        /// 关于签约的附加业务信息
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonPropertyName("join_time")]
        public string JoinTime { get; set; }

        /// <summary>
        /// 状态：1:加入 2:退出 3:清退
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
