using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SimpleOperatorModel Data Structure.
    /// </summary>
    public class SimpleOperatorModel : AlipayObject
    {
        /// <summary>
        /// 操作员id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员类型，只区分收银员和非收银员  收银员为“RESTRICTED_CASHIER”，非收银员为“STANDARD_NORMAL”
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }
    }
}
