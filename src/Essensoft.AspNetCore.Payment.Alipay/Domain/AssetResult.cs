using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetResult Data Structure.
    /// </summary>
    [Serializable]
    public class AssetResult : AlipayObject
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 批次号，分批反馈时用
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

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
        /// openapi 请求id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// AssetSubFeedbackInfo 列表
        /// </summary>
        [JsonProperty("sub_feedback_infos")]
        public List<AssetSubFeedbackInfo> SubFeedbackInfos { get; set; }

        /// <summary>
        /// 是否处理成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
