using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SingleDstCampPrizeModel Data Structure.
    /// </summary>
    public class SingleDstCampPrizeModel : AlipayObject
    {
        /// <summary>
        /// 预算id
        /// </summary>
        [JsonProperty("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 奖品id,新增不传，修改传
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 折扣幅度只能填写数字，大于0，小数点后最多2位，整数部分不能超过8位
        /// </summary>
        [JsonProperty("reduce_amt")]
        public string ReduceAmt { get; set; }
    }
}
