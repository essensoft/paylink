using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// FundItem Data Structure.
    /// </summary>
    public class FundItem : AlipayObject
    {
        /// <summary>
        /// 金额，单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金明细创建时间
        /// </summary>
        [JsonPropertyName("fund_create_time")]
        public string FundCreateTime { get; set; }

        /// <summary>
        /// 资金明细完成时间
        /// </summary>
        [JsonPropertyName("fund_finish_time")]
        public string FundFinishTime { get; set; }

        /// <summary>
        /// 资金流向
        /// </summary>
        [JsonPropertyName("fund_in_out")]
        public string FundInOut { get; set; }

        /// <summary>
        /// 资金明细更新时间
        /// </summary>
        [JsonPropertyName("fund_modify_time")]
        public string FundModifyTime { get; set; }

        /// <summary>
        /// 资金工具名（中文）
        /// </summary>
        [JsonPropertyName("fund_tool_type_name")]
        public string FundToolTypeName { get; set; }

        /// <summary>
        /// 业务创建时间
        /// </summary>
        [JsonPropertyName("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 本方卡号
        /// </summary>
        [JsonPropertyName("owner_card_no")]
        public string OwnerCardNo { get; set; }

        /// <summary>
        /// 是否为优惠资金工具
        /// </summary>
        [JsonPropertyName("promo_fund_tool")]
        public bool PromoFundTool { get; set; }
    }
}
