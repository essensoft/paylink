using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAacollectBatchCreateModel Data Structure.
    /// </summary>
    public class AlipayFundTransAacollectBatchCreateModel : AlipayObject
    {
        /// <summary>
        /// 收款备注，显示在支付宝账单
        /// </summary>
        [JsonPropertyName("batch_memo")]
        public string BatchMemo { get; set; }

        /// <summary>
        /// 渠道，由支付宝业务方提供值，目前只打印日志      taobao:淘系过来的       alipay:钱包内的      mini：小程序       other:其他来源
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 调用方扩充参数，按照Map<String,String>格式json
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 是否限定份数，true/false, 默认为不限定
        /// </summary>
        [JsonPropertyName("limit_items_total")]
        public string LimitItemsTotal { get; set; }

        /// <summary>
        /// 单笔金额,平均后的金额
        /// </summary>
        [JsonPropertyName("pay_amount_single")]
        public string PayAmountSingle { get; set; }

        /// <summary>
        /// 收款总金额，不限份数不传
        /// </summary>
        [JsonPropertyName("pay_amount_total")]
        public string PayAmountTotal { get; set; }

        /// <summary>
        /// 当前支付宝userId，即收款方支付宝userId
        /// </summary>
        [JsonPropertyName("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 付款方支付宝uid列表，按照List<String>格式json      每个uid生成一条BatchDetailModel      限定份数时必传，且人数＝实际份数
        /// </summary>
        [JsonPropertyName("payer_user_ids")]
        public string PayerUserIds { get; set; }

        /// <summary>
        /// 实际创建总笔数(若包括自己，这里为showitemsTotal-1),不限份数不传
        /// </summary>
        [JsonPropertyName("real_items_total")]
        public string RealItemsTotal { get; set; }

        /// <summary>
        /// 显示总笔数(选择的人数)，不限份数不传
        /// </summary>
        [JsonPropertyName("show_items_total")]
        public string ShowItemsTotal { get; set; }

        /// <summary>
        /// 来源，如支付宝、小程序，涉及ctu属性      钱包内淘宝求赞助:innerTBH5       钱包群收：innerBiz      小程序收款：fromMini
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
