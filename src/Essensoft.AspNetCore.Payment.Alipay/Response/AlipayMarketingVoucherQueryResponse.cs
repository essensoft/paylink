using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 券余额(元)
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 券交易账单信息(核销交易信息、交易退款信息等可能存在多条)
        /// </summary>
        [JsonPropertyName("bill_details")]
        public List<VoucherBillDetail> BillDetails { get; set; }

        /// <summary>
        /// 扩展信息,JSON格式
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 券激活时间(券可以使用起始时间)
        /// </summary>
        [JsonPropertyName("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 券创建时间(券发券时间)
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 券过期时间(券可以使用截止时间)
        /// </summary>
        [JsonPropertyName("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 券名称(用户看到券名称)
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 券状态(ENABLED:可用,DISABLED:不可用,DELETE:删除状态,TRANS:发放中,TRANSFER:已转增,UNC:未领取,USED:已使用,USING:使用中,REFUNDED:已退款,REFUNDING:使用中,UNACTIVE:未激活,EXPIRED:已过期)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板ID(模板唯一标识,创建模板返回)
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券面额(元)
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 券所属用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券ID(同入参券ID)
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
