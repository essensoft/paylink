using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DxDeployOrderInfo Data Structure.
    /// </summary>
    public class DxDeployOrderInfo : AlipayObject
    {
        /// <summary>
        /// 决策服务自定义名字空间字段
        /// </summary>
        [JsonPropertyName("biz_ns")]
        public string BizNs { get; set; }

        /// <summary>
        /// 部署事件类型,枚举值如下:  ONLINE,OFFLINE,UPDATE,VERIFY
        /// </summary>
        [JsonPropertyName("deploy_event_type")]
        public string DeployEventType { get; set; }

        /// <summary>
        /// 部署对象类型，共有4个类型:DECISION_RULE(决策规则),DECISION_ROUTER(决策分流规则),DECISION_ROUTER_PERCENT(决策策略分流百分比),DATA_SOURCE(数据源)
        /// </summary>
        [JsonPropertyName("deploy_object_type")]
        public string DeployObjectType { get; set; }

        /// <summary>
        /// 部署单内容
        /// </summary>
        [JsonPropertyName("deploy_payload")]
        public string DeployPayload { get; set; }

        /// <summary>
        /// 部署单业务创建时间
        /// </summary>
        [JsonPropertyName("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 部署的分组名
        /// </summary>
        [JsonPropertyName("group")]
        public string Group { get; set; }

        /// <summary>
        /// 重试的记录id
        /// </summary>
        [JsonPropertyName("pre_record_id")]
        public string PreRecordId { get; set; }

        /// <summary>
        /// 记录id
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 是否为重试部署单
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
