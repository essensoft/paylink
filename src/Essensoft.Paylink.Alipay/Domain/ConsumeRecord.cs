using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ConsumeRecord Data Structure.
    /// </summary>
    public class ConsumeRecord : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 业务状态
        /// </summary>
        [JsonPropertyName("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 业务状态文案
        /// </summary>
        [JsonPropertyName("biz_state_desc")]
        public string BizStateDesc { get; set; }

        /// <summary>
        /// 账单金额，单位分
        /// </summary>
        [JsonPropertyName("consume_fee")]
        public string ConsumeFee { get; set; }

        /// <summary>
        /// 删除类型
        /// </summary>
        [JsonPropertyName("delete_type")]
        public string DeleteType { get; set; }

        /// <summary>
        /// 资金明细列表
        /// </summary>
        [JsonPropertyName("fund_items")]
        public List<FundItem> FundItems { get; set; }

        /// <summary>
        /// 业务创建时间
        /// </summary>
        [JsonPropertyName("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 业务更新时间
        /// </summary>
        [JsonPropertyName("gmt_biz_modified")]
        public string GmtBizModified { get; set; }

        /// <summary>
        /// 资金流向（收入/支出）
        /// </summary>
        [JsonPropertyName("in_out")]
        public string InOut { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 对方展示logo
        /// </summary>
        [JsonPropertyName("opposite_logo")]
        public string OppositeLogo { get; set; }

        /// <summary>
        /// 对方展示名称
        /// </summary>
        [JsonPropertyName("opposite_name")]
        public string OppositeName { get; set; }

        /// <summary>
        /// 本方卡号
        /// </summary>
        [JsonPropertyName("owner_card_no")]
        public string OwnerCardNo { get; set; }

        /// <summary>
        /// 本方登录id（脱敏）
        /// </summary>
        [JsonPropertyName("owner_logon_id")]
        public string OwnerLogonId { get; set; }

        /// <summary>
        /// 本方名称（脱敏)
        /// </summary>
        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 是否是退款
        /// </summary>
        [JsonPropertyName("refund")]
        public bool Refund { get; set; }
    }
}
