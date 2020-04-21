using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantSignModel Data Structure.
    /// </summary>
    public class AlipayFinancialnetAuthContractMerchantSignModel : AlipayObject
    {
        /// <summary>
        /// 商家银行账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// json串格式的扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 费率模型
        /// </summary>
        [JsonPropertyName("fee_value")]
        public FeeValue FeeValue { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 生效失效策略模型
        /// </summary>
        [JsonPropertyName("valid_strategy")]
        public ValidStrategy ValidStrategy { get; set; }
    }
}
