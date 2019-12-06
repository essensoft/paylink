using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditOrderRepaymentApplyModel Data Structure.
    /// </summary>
    public class ZhimaCreditOrderRepaymentApplyModel : AlipayObject
    {
        /// <summary>
        /// 追赔操作类型，目前支持：  CREATE --  创建  COMPLETE -- 完结  CANCEL -- 取消
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 业务类目，由芝麻分类，商户根据自己业务选择使用；  action_type 为 CREATE 时该值不可为空；
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Json 字符串，订单对应业务信息同步，会影响订单C端展现；  如有特殊诉求，接入前找业务对口人对接
        /// </summary>
        [JsonPropertyName("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 用作业务幂等号，唯一标识一笔商户单据
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 追赔金额;   精度支持小数点后2位（金额：分）  当action_type 为 CREATE时，必填；
        /// </summary>
        [JsonPropertyName("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 追赔相关证明信息
        /// </summary>
        [JsonPropertyName("repay_proof")]
        public string RepayProof { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，确保传入与业务订单相匹配的会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
