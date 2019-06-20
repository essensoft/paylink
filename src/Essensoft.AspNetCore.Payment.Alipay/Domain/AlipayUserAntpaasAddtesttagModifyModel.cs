using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntpaasAddtesttagModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasAddtesttagModifyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账户id
        /// </summary>
        [JsonProperty("account_no")]
        public string AccountNo { get; set; }
    }
}
