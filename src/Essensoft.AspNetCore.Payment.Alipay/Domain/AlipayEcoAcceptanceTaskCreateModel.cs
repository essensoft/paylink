using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoAcceptanceTaskCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoAcceptanceTaskCreateModel : AlipayObject
    {
        /// <summary>
        /// 验收任务需要验收的用例
        /// </summary>
        [JsonPropertyName("case_list")]
        public List<TestCaseParam> CaseList { get; set; }

        /// <summary>
        /// TMALL_NEWRETAIL 调用方需要申请自己调用来源，以便于做一些逻辑管控
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 商家ID、机构ID，支付宝域即商户PID；淘宝域应该是SELLERID之类
        /// </summary>
        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 公司、机构、商家等名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 创建人USERID
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        [JsonPropertyName("creator_nick")]
        public string CreatorNick { get; set; }

        /// <summary>
        /// 用户账号类型
        /// </summary>
        [JsonPropertyName("creator_user_type")]
        public string CreatorUserType { get; set; }

        /// <summary>
        /// TIANSUOB表示 天猫新零售；BUS 表示公交行业
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 用于双向数据关联，外部ID
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 一段简要的验收描述
        /// </summary>
        [JsonPropertyName("topic")]
        public string Topic { get; set; }
    }
}
