using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BatchDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BatchDetailInfo : AlipayObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 明细批次号
        /// </summary>
        [JsonProperty("detail_no")]
        public string DetailNo { get; set; }

        /// <summary>
        /// 调用方扩充参数
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 失败原因：在status为fail时此字段不为空
        /// </summary>
        [JsonProperty("fail_message")]
        public string FailMessage { get; set; }

        /// <summary>
        /// 最后修改时间，指失败时间、成功时间、创建时间等，明细最后一次变更状态的时间
        /// </summary>
        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// 付款人留言
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 付款金额，单位为元，有两位小数
        /// </summary>
        [JsonProperty("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付成功时间
        /// </summary>
        [JsonProperty("pay_success_date")]
        public string PaySuccessDate { get; set; }

        /// <summary>
        /// 批次明细状态  AVAILABLE：可付款  SUCCESS：付款成功
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 付款订单号
        /// </summary>
        [JsonProperty("transfer_no")]
        public string TransferNo { get; set; }

        /// <summary>
        /// 付款人UID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
