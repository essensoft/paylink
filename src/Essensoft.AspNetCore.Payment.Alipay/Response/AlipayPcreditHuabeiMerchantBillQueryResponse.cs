using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantBillQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [JsonPropertyName("bill_list")]
        public List<HbMerchantBill> BillList { get; set; }

        /// <summary>
        /// 条目数，最多20000条，多余20000条请细分时间获取
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; set; }
    }
}
