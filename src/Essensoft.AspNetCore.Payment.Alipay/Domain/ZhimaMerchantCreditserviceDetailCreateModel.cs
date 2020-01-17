using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditserviceDetailCreateModel Data Structure.
    /// </summary>
    public class ZhimaMerchantCreditserviceDetailCreateModel : AlipayObject
    {
        /// <summary>
        /// 信用服务基础信息配置，为必传字段。此字段为复杂模型，其中服务名称和服务logo为必传属性。
        /// </summary>
        [JsonPropertyName("base_info_config")]
        public BaseInfoConfig BaseInfoConfig { get; set; }

        /// <summary>
        /// 业务流水号，由商户传入，为必传字段。
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 信用服务创建模式，为必传字段，可取值：direct(直连模式)；indirect(间连模式)。
        /// </summary>
        [JsonPropertyName("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 创建信用服务扩展字段，为JSON字符串。
        /// </summary>
        [JsonPropertyName("extra_info")]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 信用服务守护配置，为必传字段。此字段为复杂模型，其中商户服务电话为必传属性。
        /// </summary>
        [JsonPropertyName("promise_config")]
        public PromiseConfig PromiseConfig { get; set; }

        /// <summary>
        /// 信用服务风控配置，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [JsonPropertyName("risk_config")]
        public RiskConfig RiskConfig { get; set; }

        /// <summary>
        /// 二级商户ID。如果创建模式为间连模式，此为必传字段；如果为直连模式，不可将此字段赋值作为入参传入。
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 行业解决方案ID，为必传字段。
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }
    }
}
