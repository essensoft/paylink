using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceFixTaskCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceFixTaskCreateModel : AlipayObject
    {
        /// <summary>
        /// 应用场景: 用于在ruleScene规则场景下，对提报问题进行二次分类。 如何获取:与业务对接同学沟通后确定。
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 提交工单时的联系人名称
        /// </summary>
        [JsonPropertyName("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 提报问题的联系人电话
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 描述提报问题的详情。
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 定向开放场景中，可能同时支持多个业务场景，允许各业务场景自定义个性化提交的数据。数据格式请提前与业务接口人确定
        /// </summary>
        [JsonPropertyName("extra")]
        public List<FixExtData> Extra { get; set; }

        /// <summary>
        /// 如果工单包含图片等附件信息，首先通过文件上传接口进行文件上传，并从接口返回中获得id。此处构造的FixFileInfo对象只需包含id即可。
        /// </summary>
        [JsonPropertyName("files")]
        public List<FixFileInfo> Files { get; set; }

        /// <summary>
        /// 特殊场景下需要直接指定任务处理方时使用（非必须）。 通常需要和问题分类id配合使用。
        /// </summary>
        [JsonPropertyName("handler_id")]
        public string HandlerId { get; set; }

        /// <summary>
        /// 对接系统中该任务的唯一标识，幂等使用，如果该id对应的工单已经创建则会报错。 如何获取:对接系统自行维护的需要创建工单的唯一标识。
        /// </summary>
        [JsonPropertyName("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 对接系统自行设置自己的唯一标识。 如何获取:使用时需要与业务对接同学，确保系统名没有与现有的其他系统名重复。
        /// </summary>
        [JsonPropertyName("outer_system")]
        public string OuterSystem { get; set; }

        /// <summary>
        /// 提报问题的分类id。 如何获取:根据问题现象分类查询接口的查询结果。
        /// </summary>
        [JsonPropertyName("problem_id")]
        public long ProblemId { get; set; }

        /// <summary>
        /// 工单的业务类型。 枚举值:IoTMTN:IoT维保场景;jfMTN:生活缴费;C2B:C2B;riskControl:行业风险任务。
        /// </summary>
        [JsonPropertyName("rule_scene")]
        public string RuleScene { get; set; }

        /// <summary>
        /// 工单创建来源。对接方使用时请先与业务接口人沟通
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用来标识任务类型。 枚举值:techConsult:技术咨询;malfunctionReport:设备报障
        /// </summary>
        [JsonPropertyName("task_category")]
        public string TaskCategory { get; set; }
    }
}
