using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceOrderCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppInstserviceOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 手机号,户号，卡号等
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 权益，活动，会员
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// json标准格式
        /// </summary>
        [JsonPropertyName("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 流水创建时间
        /// </summary>
        [JsonPropertyName("flow_time")]
        public string FlowTime { get; set; }

        /// <summary>
        /// 机构
        /// </summary>
        [JsonPropertyName("inst")]
        public string Inst { get; set; }

        /// <summary>
        /// 操作动作
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 合作方子业务
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
