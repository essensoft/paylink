using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskOfflinevarsQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskOfflinevarsQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询离线变量的主键
        /// </summary>
        [JsonPropertyName("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
