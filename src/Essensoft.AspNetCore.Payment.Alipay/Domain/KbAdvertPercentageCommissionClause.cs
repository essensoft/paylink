using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertPercentageCommissionClause Data Structure.
    /// </summary>
    public class KbAdvertPercentageCommissionClause : AlipayObject
    {
        /// <summary>
        /// 分佣封顶金额
        /// </summary>
        [JsonPropertyName("max")]
        public string Max { get; set; }

        /// <summary>
        /// 分佣比例(100以内精度2位的非负小数)  例如30.04%，则输入  30.04  分佣比例存在浮动的下限，可通过业务文档获取实际值
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }
    }
}
