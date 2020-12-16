using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandSavingPassQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandSavingPassQueryModel : AlipayObject
    {
        /// <summary>
        /// 咨询来源渠道
        /// </summary>
        [JsonPropertyName("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 解决方案code ，如省卡付费会员
        /// </summary>
        [JsonPropertyName("sol_code")]
        public string SolCode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
