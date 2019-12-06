using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ValidStrategy Data Structure.
    /// </summary>
    public class ValidStrategy : AlipayObject
    {
        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonPropertyName("gmt_invalid")]
        public string GmtInvalid { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonPropertyName("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [JsonPropertyName("gmt_valid")]
        public string GmtValid { get; set; }

        /// <summary>
        /// 失效方式：  01:到期失效  02:通知失效  03:截止日期失效
        /// </summary>
        [JsonPropertyName("invalid_type")]
        public string InvalidType { get; set; }

        /// <summary>
        /// 生效类型：  01:立即生效  02:通知生效  03:预约生效  04:倒签生效
        /// </summary>
        [JsonPropertyName("valid_type")]
        public string ValidType { get; set; }
    }
}
