using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleTagQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleTagQueryResponse : AlipayResponse
    {
        /// <summary>
        /// {      "categories": [          {              "tags": [                  {                      "control": "text",                      "op": "IN",                      "sources": [                          "23905"                      ],                      "status": "EXECUTING",                      "tagCode": "pubsrv_custom_batch",                      "title": "标签描述AAAAB"                  }              ],              "title": "自定义标签"          }      ]  }    tagCode：自定义标签固定为‘pubsrv_custom_batch’    sources：取值为创建自定义标签时获取的‘selftag’自定义标签id  status： 自定义标签创建任务状态：COMPLETE:执行完成, FAIL:执行失败, EXECUTING:处理中，只有处于‘COMPLETE’状态的标签才能用于创建圈人规则
        /// </summary>
        [JsonPropertyName("customtagjson")]
        public string Customtagjson { get; set; }

        /// <summary>
        /// {"categories": [{"tags": [{"tagCode": "pubsrv_have_auto","control": "radio-normal","title": "是否有车","op": "EQ","sources": [{"value": "0","label": "否"},{"value": "1","label": "是"}]}]}    标签含义参见 alipay.marketing.campaign.rule.crowd.create （圈人规则创建）
        /// </summary>
        [JsonPropertyName("scenetagjson")]
        public string Scenetagjson { get; set; }
    }
}
