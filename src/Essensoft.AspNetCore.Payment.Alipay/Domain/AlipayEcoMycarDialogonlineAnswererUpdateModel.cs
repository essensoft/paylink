using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineAnswererUpdateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarDialogonlineAnswererUpdateModel : AlipayObject
    {
        /// <summary>
        /// 技师ID
        /// </summary>
        [JsonPropertyName("answer_id")]
        public string AnswerId { get; set; }

        /// <summary>
        /// 技师状态，0：可用，1：停用
        /// </summary>
        [JsonPropertyName("answer_status")]
        public string AnswerStatus { get; set; }
    }
}
