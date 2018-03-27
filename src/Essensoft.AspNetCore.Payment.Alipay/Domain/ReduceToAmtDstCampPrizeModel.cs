using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReduceToAmtDstCampPrizeModel Data Structure.
    /// </summary>
    public class ReduceToAmtDstCampPrizeModel : AlipayObject
    {
        /// <summary>
        /// 优惠后价格
        /// </summary>
        [JsonProperty("reduct_to_amt")]
        public string ReductToAmt { get; set; }
    }
}
