using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechConsultModel Data Structure.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechConsultModel : AlipayObject
    {
        /// <summary>
        /// 系统/应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 客户信息（JSON对象） 包含principalType主体类型、principalId主体Id、extInfo扩展信息等字段。其中，需要从extInfo透传消费的key有：relEntityId关联主体Id。
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// 事件码列表（List<String>的JSON对象）
        /// </summary>
        [JsonPropertyName("event_codes")]
        public string EventCodes { get; set; }

        /// <summary>
        /// 计价时间
        /// </summary>
        [JsonPropertyName("gmt_charge")]
        public string GmtCharge { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 扩展属性（Map<String, String>的JSON对象） key和value中不能有英文逗号及等于符号。
        /// </summary>
        [JsonPropertyName("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
