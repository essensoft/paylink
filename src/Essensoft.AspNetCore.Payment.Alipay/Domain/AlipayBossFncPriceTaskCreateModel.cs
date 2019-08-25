using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncPriceTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncPriceTaskCreateModel : AlipayObject
    {
        /// <summary>
        /// 系统名称/开放平台appId
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 价格任务请求详情参数，详见任务请求参数说明。
        /// </summary>
        [JsonProperty("apply_detail")]
        public string ApplyDetail { get; set; }

        /// <summary>
        /// 扩展属性（Map<String, String>的JSON对象）  key和value中不能有英文逗号及等于符号。
        /// </summary>
        [JsonProperty("context")]
        public string Context { get; set; }

        /// <summary>
        /// 任务创建人
        /// </summary>
        [JsonProperty("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 任务备注信息
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务号，系统根据out_biz_no + source 来进行幂等控制，因此同一个任务来源的外部业务单号必须要保证不重复
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务来源类型
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 任务子类型，标识是一个新增的任务还是一个变更的任务，新增/变更。
        /// </summary>
        [JsonProperty("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 任务类型（价格任务，政策任务，etc）
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
