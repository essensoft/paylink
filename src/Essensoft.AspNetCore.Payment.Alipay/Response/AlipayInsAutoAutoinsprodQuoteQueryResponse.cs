using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteQueryResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodQuoteQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商业费率浮动系数，0~1分值的数字，精确到小数点后4位，如：0.6589
        /// </summary>
        [JsonPropertyName("biz_discount")]
        public string BizDiscount { get; set; }

        /// <summary>
        /// 商业险续保标识,  1：新保；2：续保；3：转保
        /// </summary>
        [JsonPropertyName("biz_renewal_flag")]
        public string BizRenewalFlag { get; set; }

        /// <summary>
        /// 商业险续保公司名称
        /// </summary>
        [JsonPropertyName("biz_renewal_org")]
        public string BizRenewalOrg { get; set; }

        /// <summary>
        /// 商业险保费
        /// </summary>
        [JsonPropertyName("business_premium")]
        public string BusinessPremium { get; set; }

        /// <summary>
        /// 商业险产品信息
        /// </summary>
        [JsonPropertyName("business_product")]
        public InsProduct BusinessProduct { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [JsonPropertyName("car")]
        public Car Car { get; set; }

        /// <summary>
        /// 车主评分，分值为1-100数字，精确到个位，如：92
        /// </summary>
        [JsonPropertyName("car_owner_grade")]
        public string CarOwnerGrade { get; set; }

        /// <summary>
        /// 如果是图片验证码问题，返回验证码的base64流
        /// </summary>
        [JsonPropertyName("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 图片验证码标识
        /// </summary>
        [JsonPropertyName("check_code_id")]
        public string CheckCodeId { get; set; }

        /// <summary>
        /// 0-不需要、1-江苏验证码、2-中保信验证码
        /// </summary>
        [JsonPropertyName("check_code_type")]
        public string CheckCodeType { get; set; }

        /// <summary>
        /// 保险公司ID
        /// </summary>
        [JsonPropertyName("com_id")]
        public string ComId { get; set; }

        /// <summary>
        /// 保险公司简称
        /// </summary>
        [JsonPropertyName("com_name")]
        public string ComName { get; set; }

        /// <summary>
        /// 正确车险信息
        /// </summary>
        [JsonPropertyName("correct_car_models")]
        public List<CarModel> CorrectCarModels { get; set; }

        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [JsonPropertyName("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 交强费率浮动系数，0~1分值的数字，精确到小数点后4位，如：0.6589
        /// </summary>
        [JsonPropertyName("force_discount")]
        public string ForceDiscount { get; set; }

        /// <summary>
        /// 交强险保费
        /// </summary>
        [JsonPropertyName("force_premium")]
        public string ForcePremium { get; set; }

        /// <summary>
        /// 交强险产品信息
        /// </summary>
        [JsonPropertyName("force_product")]
        public InsProduct ForceProduct { get; set; }

        /// <summary>
        /// 交强险续保标识; 1：新保；2：续保；3：转保
        /// </summary>
        [JsonPropertyName("force_renewal_flag")]
        public string ForceRenewalFlag { get; set; }

        /// <summary>
        /// 交强险续保公司名称
        /// </summary>
        [JsonPropertyName("force_renewal_org")]
        public string ForceRenewalOrg { get; set; }

        /// <summary>
        /// 支持的物流配送方式
        /// </summary>
        [JsonPropertyName("logistics_models")]
        public List<string> LogisticsModels { get; set; }

        /// <summary>
        /// 允许调整的最大渠道系数，精确到小数点后十位
        /// </summary>
        [JsonPropertyName("max_self_channel_ratio")]
        public string MaxSelfChannelRatio { get; set; }

        /// <summary>
        /// 允许调整的最大核保系数，精确到小数点后十位
        /// </summary>
        [JsonPropertyName("max_self_underwrite_ratio")]
        public string MaxSelfUnderwriteRatio { get; set; }

        /// <summary>
        /// 允许调整的最小渠道系数，精确到小数点后十位
        /// </summary>
        [JsonPropertyName("min_self_channel_ratio")]
        public string MinSelfChannelRatio { get; set; }

        /// <summary>
        /// 允许调整的最小核保系数，精确到小数点后十位
        /// </summary>
        [JsonPropertyName("min_self_underwrite_ratio")]
        public string MinSelfUnderwriteRatio { get; set; }

        /// <summary>
        /// 平台NCD系数，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("no_claim_adjust_ratio")]
        public string NoClaimAdjustRatio { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonPropertyName("quote_biz_id")]
        public string QuoteBizId { get; set; }

        /// <summary>
        /// 报价失败错误码，这个很重要
        /// </summary>
        [JsonPropertyName("quote_error_code")]
        public string QuoteErrorCode { get; set; }

        /// <summary>
        /// 报价失败提示信息
        /// </summary>
        [JsonPropertyName("quote_error_msg")]
        public string QuoteErrorMsg { get; set; }

        /// <summary>
        /// 实付保费[优惠后用户应付金额]
        /// </summary>
        [JsonPropertyName("real_premium")]
        public string RealPremium { get; set; }

        /// <summary>
        /// 优惠保费
        /// </summary>
        [JsonPropertyName("reduce_premium")]
        public string ReducePremium { get; set; }

        /// <summary>
        /// 保司自主渠道系数，精确到小数点后十位
        /// </summary>
        [JsonPropertyName("self_channel_ratio")]
        public string SelfChannelRatio { get; set; }

        /// <summary>
        /// 保司自主核保系数，精确到小数点后十位
        /// </summary>
        [JsonPropertyName("self_underwrite_ratio")]
        public string SelfUnderwriteRatio { get; set; }

        /// <summary>
        /// 总保费
        /// </summary>
        [JsonPropertyName("total_premium")]
        public string TotalPremium { get; set; }

        /// <summary>
        /// 交通违法系数,精确到小数点后两位
        /// </summary>
        [JsonPropertyName("traffic_violation_ratio")]
        public string TrafficViolationRatio { get; set; }

        /// <summary>
        /// 客户评级信息，辅助作业人员展业(具体内容以保司信息为准)
        /// </summary>
        [JsonPropertyName("user_level")]
        public string UserLevel { get; set; }

        /// <summary>
        /// 用户提醒code
        /// </summary>
        [JsonPropertyName("warn_code")]
        public string WarnCode { get; set; }

        /// <summary>
        /// 用户提示内容
        /// </summary>
        [JsonPropertyName("warn_message")]
        public string WarnMessage { get; set; }
    }
}
