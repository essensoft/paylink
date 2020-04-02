using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelRateRateinfoQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelRateRateinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 权益汇率列表：每个汇率权益级别对应的汇率；见ClassRateInfo.grade字段
        /// </summary>
        [JsonPropertyName("benefit_rate_list")]
        public List<ClassRateInfo> BenefitRateList { get; set; }

        /// <summary>
        /// 对比汇率：用户计算汇率的优惠力度
        /// </summary>
        [JsonPropertyName("contrast_rate")]
        public string ContrastRate { get; set; }

        /// <summary>
        /// 对比汇率金额：用于计算汇率优惠金额，单位是元 如： 钻石汇率优惠金额=钻石权益级别汇率金额-对比汇率金额； 用户汇率优惠金额=用户汇率金额-对比汇率金额
        /// </summary>
        [JsonPropertyName("contrast_rate_amount")]
        public string ContrastRateAmount { get; set; }

        /// <summary>
        /// 货币代码，ISO标准alpha-3币种代码
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 货币icon的url地址
        /// </summary>
        [JsonPropertyName("currency_icon")]
        public string CurrencyIcon { get; set; }

        /// <summary>
        /// 会员汇率列表：会员每个等级对应的汇率，具体会员等级见ClassRateInfo.grade字段
        /// </summary>
        [JsonPropertyName("member_rate_list")]
        public List<ClassRateInfo> MemberRateList { get; set; }

        /// <summary>
        /// 汇率描述
        /// </summary>
        [JsonPropertyName("rate_desc")]
        public string RateDesc { get; set; }

        /// <summary>
        /// 汇率来源说明
        /// </summary>
        [JsonPropertyName("rate_source")]
        public string RateSource { get; set; }

        /// <summary>
        /// 当参数中user_id不为空时返回，权益等级： - diamond(钻石权益) - platinum(铂金权益) - others(无权益)
        /// </summary>
        [JsonPropertyName("user_benefit_grade")]
        public string UserBenefitGrade { get; set; }

        /// <summary>
        /// 当参数中user_id不为空时返回， 会员等级：  - diamond(钻石会员)  - platinum(铂金会员)  - golden(黄金会员)  - primary(大众会员)
        /// </summary>
        [JsonPropertyName("user_member_grade")]
        public string UserMemberGrade { get; set; }

        /// <summary>
        /// 当参数中user_id不为空时，返回用户汇率，为支付宝当面付的当前币种/CNY的汇率值，如6.2345;
        /// </summary>
        [JsonPropertyName("user_rate")]
        public string UserRate { get; set; }

        /// <summary>
        /// 当参数中user_id不为空时，返回用户用户汇率金额，单位元
        /// </summary>
        [JsonPropertyName("user_rate_amount")]
        public string UserRateAmount { get; set; }
    }
}
