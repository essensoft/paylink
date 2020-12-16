using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAgentSignstatusQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAgentSignstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// isv要查询签约状态的商户账号，是支付宝账号pid（2088开头）
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// isv要查询商户签约状态的产品码，产品码是支付宝内部对产品的唯一标识。目前支持查询产品及产品码详情参见 https://opendocs.alipay.com/isv/01cv77#%E8%83%BD%E5%8A%9B%E4%BA%A7%E5%93%81%E7%A0%81 。 
        /// </summary>
        [JsonPropertyName("product_codes")]
        public List<string> ProductCodes { get; set; }
    }
}
