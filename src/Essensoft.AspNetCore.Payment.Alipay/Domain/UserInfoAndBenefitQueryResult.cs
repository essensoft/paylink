using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserInfoAndBenefitQueryResult Data Structure.
    /// </summary>
    public class UserInfoAndBenefitQueryResult : AlipayObject
    {
        /// <summary>
        /// 用户的蚂蚁会员积分余额
        /// </summary>
        [JsonPropertyName("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 蚂蚁会员权益配置信息列表
        /// </summary>
        [JsonPropertyName("benefit_info_list")]
        public List<BenefitGradePoint> BenefitInfoList { get; set; }

        /// <summary>
        /// 用户的蚂蚁会员等级
        /// </summary>
        [JsonPropertyName("grade")]
        public string Grade { get; set; }
    }
}
