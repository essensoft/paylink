using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskVerifyModel Data Structure.
    /// </summary>
    public class AlipaySocialQuestionnareTaskVerifyModel : AlipayObject
    {
        /// <summary>
        /// 用户Id，多个以逗号分割
        /// </summary>
        [JsonPropertyName("buyer_user_ids")]
        public string BuyerUserIds { get; set; }

        /// <summary>
        /// 业务扩展字段JSON格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [JsonPropertyName("qstn_id")]
        public string QstnId { get; set; }

        /// <summary>
        /// UONE问券ID
        /// </summary>
        [JsonPropertyName("rmt_qstn_id")]
        public string RmtQstnId { get; set; }
    }
}
