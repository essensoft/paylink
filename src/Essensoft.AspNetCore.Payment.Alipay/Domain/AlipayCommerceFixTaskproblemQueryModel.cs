using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceFixTaskproblemQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceFixTaskproblemQueryModel : AlipayObject
    {
        /// <summary>
        /// 非必须，仅用在部分行业，请与业务对接同学沟通后确定是否使用。
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 非必须，只在iot场景下使用。机型的itemId。
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 问题类型的一级分类。 如何获取:与业务对接同学确认
        /// </summary>
        [JsonPropertyName("problem_level_1")]
        public string ProblemLevel1 { get; set; }

        /// <summary>
        /// 问题类型的二级分类。 如何获取:根据一级分类的查询结果。
        /// </summary>
        [JsonPropertyName("problem_level_2")]
        public string ProblemLevel2 { get; set; }

        /// <summary>
        /// 生态协同单的业务类型。 枚举值:IoTMTN:IoT维保场景;jfMTN:生活缴费;C2B:C2B;riskControl:行业风险任务。
        /// </summary>
        [JsonPropertyName("rule_scene")]
        public string RuleScene { get; set; }

        /// <summary>
        /// 用来标识接口返回的是提报端，还是处理端使用的问题分类列表。 枚举值:SUBMIT:维保提报端;DEAL:维保处理端
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    }
}
