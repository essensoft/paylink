using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RandomDiscountDstCampPrizeModel Data Structure.
    /// </summary>
    public class RandomDiscountDstCampPrizeModel : AlipayObject
    {
        /// <summary>
        /// 折扣预算ID
        /// </summary>
        [JsonPropertyName("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 随机立减折扣幅度列表
        /// </summary>
        [JsonPropertyName("discount_random_model_list")]
        public List<DiscountRandomModel> DiscountRandomModelList { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 最高优惠金额=订单金额X(1-封顶折扣)  折扣幅度必须为0.3到1之间的小数(保留小数点后2位)
        /// </summary>
        [JsonPropertyName("max_random_discount_rate")]
        public string MaxRandomDiscountRate { get; set; }
    }
}
