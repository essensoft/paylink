using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCashticketTemplateModifyModel Data Structure.
    /// </summary>
    public class AlipayMarketingCashticketTemplateModifyModel : AlipayObject
    {
        /// <summary>
        /// 外部业务单号，用作幂等控制，相同template_id下相同out_biz_no视为同一次修改。注意，此值不是修改模板的out_biz_no属性
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发放结束时间，晚于该时间不能发票。票的发放结束时间和发放开始时间跨度不能大于5年（一年按照365天计算）。发放结束时间必须晚于发放开始时间。格式为：yyyy-MM-dd HH:mm:ss。草稿状态和生效状态可修改，如果此值不想被修改，请传原值
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 发放开始时间，早于该时间不能发票。发放开始时间不能大于当前时间15天。格式为：yyyy-MM-dd HH:mm:ss。仅草稿状态可修改。仅草稿状态可修改，如果此值不想被修改，请传原值
        /// </summary>
        [JsonPropertyName("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 票模板ID。通过票模板创建接口接口获取
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 票有效期。有两种类型：绝对时间和相对时间。使用JSON字符串表示。绝对时间有3个key：type、start、end，type取值固定为"ABSOLUTE"，start和end分别表示票生效时间和失效时间，格式为yyyy-MM-dd HH:mm:ss。绝对时间示例：{"type": "ABSOLUTE", "start": "2017-01-10 00:00:00", "end": "2017-01-13 23:59:59"}。相对时间有3个key：type、duration、unit，type取值固定为"RELATIVE"，duration表示从发票时间开始到往后推duration个单位时间为止作为票的使用有效期，unit表示有效时间单位，有效时间单位可枚举：MINUTE, HOUR, DAY。示例：{"type": "RELATIVE", "duration": 1 , "unit": "DAY" }，如果此刻发票，那么票从现在开始生效1(duration)天(unit)后失效，如果此值不想被修改，请传原值
        /// </summary>
        [JsonPropertyName("ticket_valid_period")]
        public string TicketValidPeriod { get; set; }
    }
}
