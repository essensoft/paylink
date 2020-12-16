using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceRiskApplyModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceRiskApplyModel : AlipayObject
    {
        /// <summary>
        /// 因何种资产业务发起的贷前风控申请
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 请求的唯一性标识，用于幂等处理。 若不传，则使用风控参数作为幂等条件
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// JSON字符串，字段参见资产字段信息表，风控字段。
        /// </summary>
        [JsonPropertyName("risk_object")]
        public string RiskObject { get; set; }

        /// <summary>
        /// 风控类型，默认贷前风控
        /// </summary>
        [JsonPropertyName("risk_type")]
        public string RiskType { get; set; }
    }
}
