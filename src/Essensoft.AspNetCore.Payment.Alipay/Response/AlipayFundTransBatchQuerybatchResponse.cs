using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransBatchQuerybatchResponse.
    /// </summary>
    public class AlipayFundTransBatchQuerybatchResponse : AlipayResponse
    {
        /// <summary>
        /// 收款理由：创建时传入的收款说明
        /// </summary>
        [JsonPropertyName("batch_memo")]
        public string BatchMemo { get; set; }

        /// <summary>
        /// 批次编号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// INAVAILABLE:系统异常，  AVAILABLE：可付款，  FINISH：已完成，  SUCCESS：所有的单据创建成功并且都付款成功，  TIMEOUT：已过期
        /// </summary>
        [JsonPropertyName("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// aa：AA收款，  general：活动收款，  support：群江湖救急
        /// </summary>
        [JsonPropertyName("batch_type")]
        public string BatchType { get; set; }

        /// <summary>
        /// 批次最后修改时间
        /// </summary>
        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 批次创建者id
        /// </summary>
        [JsonPropertyName("create_user_id")]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 批次详情
        /// </summary>
        [JsonPropertyName("detail_list")]
        public QueryDetailAopResult DetailList { get; set; }

        /// <summary>
        /// 扩展数据，创建批次时传入的扩展数据；注：长度限制100
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 单笔金额，单位为元。注： AA收款为平均后的金额；活动收款为单笔金额； 江湖救急没有值；即创建批次时传入的相关数据
        /// </summary>
        [JsonPropertyName("pay_amount_single")]
        public string PayAmountSingle { get; set; }

        /// <summary>
        /// 总金额，单位为元。注：AA为收款总金额；活动收款为份数和单笔金额的积；江湖救急为目标金额；即为创建批次时传入的相关数据
        /// </summary>
        [JsonPropertyName("pay_amount_total")]
        public string PayAmountTotal { get; set; }

        /// <summary>
        /// 实际要创建的笔数。注：AA包括自己这里为show_items_total-1；活动收款为填写的份数;江湖救急没有值；即创建批次时传入的相关值
        /// </summary>
        [JsonPropertyName("real_items_total")]
        public string RealItemsTotal { get; set; }

        /// <summary>
        /// 显示的总笔数。注：AA收款为选择的人数；活动收款为填写的份数；江湖救急没有值；即创建批次时传入的相关值
        /// </summary>
        [JsonPropertyName("show_items_total")]
        public string ShowItemsTotal { get; set; }

        /// <summary>
        /// 已付总金额，单位为元
        /// </summary>
        [JsonPropertyName("success_amount_total")]
        public string SuccessAmountTotal { get; set; }

        /// <summary>
        /// 已付总笔数
        /// </summary>
        [JsonPropertyName("success_items_total")]
        public string SuccessItemsTotal { get; set; }

        /// <summary>
        /// 过期时间，单位为小时
        /// </summary>
        [JsonPropertyName("time_out_value")]
        public string TimeOutValue { get; set; }

        /// <summary>
        /// token：创建批次时下发的token
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
