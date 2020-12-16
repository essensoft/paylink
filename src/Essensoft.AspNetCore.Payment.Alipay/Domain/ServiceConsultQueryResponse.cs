using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceConsultQueryResponse Data Structure.
    /// </summary>
    public class ServiceConsultQueryResponse : AlipayObject
    {
        /// <summary>
        /// 支付宝侧服务咨询单号
        /// </summary>
        [JsonPropertyName("consult_event_id")]
        public string ConsultEventId { get; set; }

        /// <summary>
        /// 咨询内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 咨询单创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 咨询工单结束时间，当工单达到终态时，才会有结束时间
        /// </summary>
        [JsonPropertyName("gmt_finished")]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 咨询工单修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 咨询图片
        /// </summary>
        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 最近一笔商家订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 咨询人电话号码
        /// </summary>
        [JsonPropertyName("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [JsonPropertyName("question_type")]
        public string QuestionType { get; set; }

        /// <summary>
        /// 二级问题类型
        /// </summary>
        [JsonPropertyName("second_question_type")]
        public string SecondQuestionType { get; set; }

        /// <summary>
        /// 状态 商家处理中：MERCHANT_PROCESSING 商家已回复： MERCHANT_REPLIED 已撤销： CANCELLED 系统关闭： CLOSED
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用id，例如小程序id
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 应用类型 小程序为：APPID 生活号为：PUBLICID
        /// </summary>
        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 最近一笔支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
