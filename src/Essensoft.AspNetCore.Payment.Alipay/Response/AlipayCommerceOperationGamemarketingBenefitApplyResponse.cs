using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceOperationGamemarketingBenefitApplyResponse.
    /// </summary>
    public class AlipayCommerceOperationGamemarketingBenefitApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值是个卡券兑换码的列表
        /// </summary>
        [JsonPropertyName("apply_voucher_code_list")]
        public List<string> ApplyVoucherCodeList { get; set; }
    }
}
