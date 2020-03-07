using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCashlessticketTemplateModifyModel Data Structure.
    /// </summary>
    public class AlipayMarketingCashlessticketTemplateModifyModel : AlipayObject
    {
        /// <summary>
        /// 模板修改操作外部业务号，用于修改时的幂等控制，注意这里不是修改创建模板时的业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发放结束时间，晚于该时间不能发票。票的发放结束时间和发放开始时间跨度不能大于5年（一年按照365天计算）。发放结束时间必须晚于发放开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 则配置，JSON字符串，{"PID":"2088102147297014","STORE":"123456,678901","MerchantMarketingSign":{"userDefinedValue":"AAA","belongType":"Y"}}，其中PID表示可以核销该票的PID列表，多个值用英文逗号隔开，STORE表示可以核销该票的内部门店ID，多个值用英文逗号隔开，不传此参数则不修改规则，若有要修改规则那么必须包含PID，且PID范围和STOREID范围只允许扩大，不允许缩小。特别注意： 如果传入的核销规则中没有自定义核销规则字段，那么表示自定义核销规则就会被取消，只根据PID规则和STORE规则进行核销
        /// </summary>
        [JsonPropertyName("rule_conf")]
        public string RuleConf { get; set; }

        /// <summary>
        /// 票模板ID ，通过调用alipay.marketing.cashlessticket.template.create接口返回
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
