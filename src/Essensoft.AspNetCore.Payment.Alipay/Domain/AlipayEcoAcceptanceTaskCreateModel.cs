using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoAcceptanceTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoAcceptanceTaskCreateModel : AlipayObject
    {
        /// <summary>
        /// 验收任务需要验收的用例
        /// </summary>
        [JsonProperty("case_list")]
        public List<TestCaseParam> CaseList { get; set; }

        /// <summary>
        /// TMALL_NEWRETAIL 调用方需要申请自己调用来源，以便于做一些逻辑管控
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 商家ID、机构ID，支付宝域即商户PID；淘宝域应该是SELLERID之类
        /// </summary>
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 公司、机构、商家等名称
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 创建人USERID
        /// </summary>
        [JsonProperty("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        [JsonProperty("creator_nick")]
        public string CreatorNick { get; set; }

        /// <summary>
        /// 用户账号类型
        /// </summary>
        [JsonProperty("creator_user_type")]
        public string CreatorUserType { get; set; }

        /// <summary>
        /// TIANSUOB表示 天猫新零售；BUS 表示公交行业
        /// </summary>
        [JsonProperty("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 用于双向数据关联，外部ID
        /// </summary>
        [JsonProperty("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 一段简要的验收描述
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; }
    }
}
