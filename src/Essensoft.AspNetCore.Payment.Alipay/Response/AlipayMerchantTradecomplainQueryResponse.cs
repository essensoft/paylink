using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantTradecomplainQueryResponse.
    /// </summary>
    public class AlipayMerchantTradecomplainQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        [JsonPropertyName("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 用户投诉原因
        /// </summary>
        [JsonPropertyName("complain_reason")]
        public string ComplainReason { get; set; }

        /// <summary>
        /// 用户投诉内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 投诉单创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 投诉单完结时间
        /// </summary>
        [JsonPropertyName("gmt_finished")]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 投诉单修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 投诉图片
        /// </summary>
        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 用户投诉诉求
        /// </summary>
        [JsonPropertyName("leaf_category_name")]
        public string LeafCategoryName { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 投诉人电话号码
        /// </summary>
        [JsonPropertyName("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 用户与商家之间的协商记录
        /// </summary>
        [JsonPropertyName("reply_detail_infos")]
        public List<ReplyRecordResponse> ReplyDetailInfos { get; set; }

        /// <summary>
        /// 状态  商家处理中：MERCHANT_PROCESSING  商家已反馈：MERCHANT_FEEDBACKED  投诉已完结：FINISHED  投诉已撤销：CANCELLED  平台处理中：PLATFORM_PROCESSING  平台处理完结：PLATFORM_FINISH  系统关闭：CLOSED
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用id，例如小程序id
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 应用类型 小程序传入：APPID 生活号传入：PUBLICID
        /// </summary>
        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 交易金额，单位元
        /// </summary>
        [JsonPropertyName("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
