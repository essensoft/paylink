using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectSourceQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectSourceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 间连商户等级。 INDIRECT_LEVEL_M0：M0级; INDIRECT_LEVEL_M1：M1级; INDIRECT_LEVEL_M2：M2级; INDIRECT_LEVEL_M3：M3级； INDIRECT_LEVEL_M4：M4级；
        /// </summary>
        [JsonPropertyName("indirect_level")]
        public string IndirectLevel { get; set; }

        /// <summary>
        /// 当间连商户为M4等级时，该字段才有值，代表商户认领的支付宝pid
        /// </summary>
        [JsonPropertyName("merchant_confirm_pid")]
        public string MerchantConfirmPid { get; set; }
    }
}
