using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserBillSimpleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserBillSimpleQueryModel : AlipayObject
    {
        /// <summary>
        /// 28位或32位支付宝交易流水号
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 本方卡号（对应用户userid），即16位的2088开头的支付宝uid。
        /// </summary>
        [JsonProperty("owner_card_no")]
        public string OwnerCardNo { get; set; }
    }
}
