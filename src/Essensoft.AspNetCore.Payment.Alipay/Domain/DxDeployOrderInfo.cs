using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DxDeployOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DxDeployOrderInfo : AlipayObject
    {
        /// <summary>
        /// 决策服务自定义名字空间字段
        /// </summary>
        [JsonProperty("biz_ns")]
        public string BizNs { get; set; }

        /// <summary>
        /// 部署事件类型,枚举值如下:  ONLINE,OFFLINE,UPDATE,VERIFY
        /// </summary>
        [JsonProperty("deploy_event_type")]
        public string DeployEventType { get; set; }

        /// <summary>
        /// 部署对象类型，共有4个类型:DECISION_RULE(决策规则),DECISION_ROUTER(决策分流规则),DECISION_ROUTER_PERCENT(决策策略分流百分比),DATA_SOURCE(数据源)
        /// </summary>
        [JsonProperty("deploy_object_type")]
        public string DeployObjectType { get; set; }

        /// <summary>
        /// 部署单内容
        /// </summary>
        [JsonProperty("deploy_payload")]
        public string DeployPayload { get; set; }

        /// <summary>
        /// 部署单业务创建时间
        /// </summary>
        [JsonProperty("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 部署的分组名
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// 重试的记录id
        /// </summary>
        [JsonProperty("pre_record_id")]
        public string PreRecordId { get; set; }

        /// <summary>
        /// 记录id
        /// </summary>
        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 是否为重试部署单
        /// </summary>
        [JsonProperty("retry")]
        public bool Retry { get; set; }
    }
}
