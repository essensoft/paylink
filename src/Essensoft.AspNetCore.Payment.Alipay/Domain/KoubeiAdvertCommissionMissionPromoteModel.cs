using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionPromoteModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionMissionPromoteModel : AlipayObject
    {
        /// <summary>
        /// 推广主键  identify_type=mission-值必须是任务ID  identify_type=voucher-值必须是券ID
        /// </summary>
        [JsonPropertyName("identify")]
        public string Identify { get; set; }

        /// <summary>
        /// 推广主键类型  mission-任务  voucher-券
        /// </summary>
        [JsonPropertyName("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 指定推广活动的名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
