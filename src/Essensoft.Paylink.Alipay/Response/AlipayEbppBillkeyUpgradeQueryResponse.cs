using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppBillkeyUpgradeQueryResponse.
    /// </summary>
    public class AlipayEbppBillkeyUpgradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 户号
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型英文名称 ，例如传JF，表示缴费
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构名称
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 子业务类型英文名称，ELECTRIC-电费，WATER-水费，GAS-燃气费
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
