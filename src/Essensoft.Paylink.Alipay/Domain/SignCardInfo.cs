using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SignCardInfo Data Structure.
    /// </summary>
    public class SignCardInfo : AlipayObject
    {
        /// <summary>
        /// 完整卡号的SHA256摘要并对结果进行16进制编码
        /// </summary>
        [JsonPropertyName("card_no_en")]
        public string CardNoEn { get; set; }

        /// <summary>
        /// 卡号前八位
        /// </summary>
        [JsonPropertyName("first_eight_card_no")]
        public string FirstEightCardNo { get; set; }
    }
}
