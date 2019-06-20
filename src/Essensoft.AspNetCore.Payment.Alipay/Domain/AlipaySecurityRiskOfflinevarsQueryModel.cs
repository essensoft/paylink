using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskOfflinevarsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskOfflinevarsQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询离线变量的主键
        /// </summary>
        [JsonProperty("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
