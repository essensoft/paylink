using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryAccountCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenInstantdeliveryAccountCreateModel : AlipayObject
    {
        /// <summary>
        /// 配送公司编码
        /// </summary>
        [JsonPropertyName("logistics_codes")]
        public List<string> LogisticsCodes { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
