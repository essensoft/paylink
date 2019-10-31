using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillBalancehisQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillBalancehisQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥
        /// </summary>
        [JsonProperty("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥
        /// </summary>
        [JsonProperty("biz_month")]
        public string BizMonth { get; set; }
    }
}
