using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessOrdersFeedBackResult Data Structure.
    /// </summary>
    [Serializable]
    public class AccessOrdersFeedBackResult : AlipayObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonProperty("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 反馈主键ID（生产单ID或者采购单ID或者码token）
        /// </summary>
        [JsonProperty("feedback_id")]
        public string FeedbackId { get; set; }

        /// <summary>
        /// 生产单：PRODUCE_ORDER  采购单：PURCHASE_ORDER  二维码：QRCODE
        /// </summary>
        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部单据号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 每条记录处理结果
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
