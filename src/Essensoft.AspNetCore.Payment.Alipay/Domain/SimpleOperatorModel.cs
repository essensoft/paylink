using Newtonsoft.Json;

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
        [JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员类型，只区分收银员和非收银员  收银员为“RESTRICTED_CASHIER”，非收银员为“STANDARD_NORMAL”
        /// </summary>
        [JsonProperty("operator_type")]
        public string OperatorType { get; set; }
    }
}
