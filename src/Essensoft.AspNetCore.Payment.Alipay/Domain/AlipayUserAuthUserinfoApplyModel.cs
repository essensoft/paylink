using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAuthUserinfoApplyModel Data Structure.
    /// </summary>
    public class AlipayUserAuthUserinfoApplyModel : AlipayObject
    {
        /// <summary>
        /// 业务号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        [JsonPropertyName("ext_data")]
        public string ExtData { get; set; }
    }
}
