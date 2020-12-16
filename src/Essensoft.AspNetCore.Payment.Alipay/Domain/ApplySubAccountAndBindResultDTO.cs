using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApplySubAccountAndBindResultDTO Data Structure.
    /// </summary>
    public class ApplySubAccountAndBindResultDTO : AlipayObject
    {
        /// <summary>
        /// 受理单号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 受理单状态，申请成功后受理单状态为INIT
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }
    }
}
