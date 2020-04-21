using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeBankBranchQueryModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeBankBranchQueryModel : AlipayObject
    {
        /// <summary>
        /// 支持全称，或部分名称。银行名称不单独传参，需要其它条件一起使用，允许的几种模式： 1. 银行名称 + 总行联行号 + 行政地区编码 2. 银行名称 + 总行联行号
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 行政地区编码。行政地区编码不单独传参，需要其它条件一起使用，允许的几种模式： 1. 银行名称 + 总行联行号 + 行政地区编码 2. 总行联行号 + 行政地区编码
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 总行联行号。总行联行号不单独传参，需要其它条件一起使用，允许的几种模式： 1. 银行名称 + 总行联行号 + 行政地区编码 2. 银行名称 + 总行联行号 3. 总行联行号 + 行政地区编码
        /// </summary>
        [JsonPropertyName("root_bank_code")]
        public string RootBankCode { get; set; }
    }
}
