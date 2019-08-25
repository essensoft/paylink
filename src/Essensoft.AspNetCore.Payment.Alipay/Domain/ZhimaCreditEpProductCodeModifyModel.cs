using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpProductCodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpProductCodeModifyModel : AlipayObject
    {
        /// <summary>
        /// 二维码唯一标识id
        /// </summary>
        [JsonProperty("code_id")]
        public string CodeId { get; set; }
    }
}
