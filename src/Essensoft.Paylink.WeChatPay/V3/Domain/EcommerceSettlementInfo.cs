using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// /// <summary>
    /// 结算规则
    /// </summary>
    /// </summary>
    public class EcommerceSettlementInfo : WeChatPayObject
    {
        /// <summary>
        /// 入驻结算规则ID
        /// </summary>
        /// <remarks>
        /// 请选择结算规则ID，详细参见《费率结算规则对照表》。
        /// <para>示例值：719</para>
        /// </remarks>
        [JsonPropertyName("settlement_id")]
        public int SettlementId { get; set; }

        /// <summary>
        /// 所属行业
        /// </summary>
        /// <remarks>
        /// 请填写所属行业名称，详细参见《费率结算规则对照表》。
        /// <para>示例值：餐饮</para>
        /// </remarks>
        [JsonPropertyName("qualification_type")]
        public string QualificationType { get; set; }
    }
}
