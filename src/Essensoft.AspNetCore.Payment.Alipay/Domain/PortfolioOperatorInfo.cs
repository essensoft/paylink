using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PortfolioOperatorInfo Data Structure.
    /// </summary>
    public class PortfolioOperatorInfo : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为   koubei.member.data.oauth.query 中的auth_code，默认有效期24小时；ISV自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 如果是 ISV 代操作，请传入 ISV；  如果是其他角色（商户MER、商户操作员MER_OPERATOR、服务商PROVIDER、服务商员工PROVIDER_STAFF、系统SYSTEM）操作，不用填写。
        /// </summary>
        [JsonPropertyName("op_role")]
        public string OpRole { get; set; }
    }
}
