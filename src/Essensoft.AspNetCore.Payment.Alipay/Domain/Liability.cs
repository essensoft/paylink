using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Liability Data Structure.
    /// </summary>
    public class Liability : AlipayObject
    {
        /// <summary>
        /// 是否投保不计免赔，0-否，1-是
        /// </summary>
        [JsonPropertyName("iop")]
        public string Iop { get; set; }

        /// <summary>
        /// 标准责任编码
        /// </summary>
        [JsonPropertyName("liability_no")]
        public string LiabilityNo { get; set; }

        /// <summary>
        /// 保额，单位分(分金额类的保额和枚举类的保额，注意参考数据字典)
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public string SumInsured { get; set; }
    }
}
