using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpProductCodeApplyResponse.
    /// </summary>
    public class ZhimaCreditEpProductCodeApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 批次号,本次申请单据号与商户所传org_biz_no一一对应
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申码结果信息:  code_id  二维码唯一标识id;  code_url 二维码url地址
        /// </summary>
        [JsonPropertyName("code_list")]
        public List<CodeResInfo> CodeList { get; set; }
    }
}
