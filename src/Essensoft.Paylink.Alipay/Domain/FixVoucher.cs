using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// FixVoucher Data Structure.
    /// </summary>
    public class FixVoucher : AlipayObject
    {
        /// <summary>
        /// 面额，每张代金券可以抵扣的金额。    限制：  币种为人民币，单位为元。小数点以后最多保留两位。    取值范围:0.1<=x<=3000
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 门槛金额。该字段不填写，认为无门槛。    限制： 只有当订单金额大于等于门槛金额时券才能使用。    币种为人民币，单位为元。小数点以后最多保留两位。    设置门槛：取值范围:0.1<=x<= 50000。  如果设置了门槛金额，则必须大于等于0.1，不可以等于0
        /// </summary>
        [JsonPropertyName("floor_amount")]
        public string FloorAmount { get; set; }
    }
}
