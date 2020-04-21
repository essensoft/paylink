using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorDepositQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositQueryModel : AlipayObject
    {
        /// <summary>
        /// 交通卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 和渠道定义的卡类型，一个城市支持一种卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// transfer：待圈存 success：圈存成功 fail：圈存失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
