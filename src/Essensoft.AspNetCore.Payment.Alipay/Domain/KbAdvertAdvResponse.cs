using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAdvResponse Data Structure.
    /// </summary>
    public class KbAdvertAdvResponse : AlipayObject
    {
        /// <summary>
        /// 推广ID
        /// </summary>
        [JsonPropertyName("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 指定推广活动的名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 单张券推广  只有type=single_voucher才会有值
        /// </summary>
        [JsonPropertyName("single_voucher")]
        public KbAdvertAdvSingleVoucherResponse SingleVoucher { get; set; }

        /// <summary>
        /// 推广类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
