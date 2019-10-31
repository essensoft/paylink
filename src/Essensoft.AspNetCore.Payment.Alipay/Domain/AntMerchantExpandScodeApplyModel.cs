using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandScodeApplyModel : AlipayObject
    {
        /// <summary>
        /// apply_code_request，申请S码的请求参数
        /// </summary>
        [JsonProperty("apply_code_request")]
        public List<ApplyCodeRequest> ApplyCodeRequest { get; set; }
    }
}
