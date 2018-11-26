using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("available_amount")]
        [XmlElement("available_amount")]
        public long AvailableAmount { get; set; }

        /// <summary>
        /// 券交易账单信息(核销交易信息、交易退款信息等可能存在多条)
        /// </summary>
        [JsonProperty("bill_details")]
        [XmlArray("bill_details")]
        [XmlArrayItem("voucher_bill_detail")]
        public List<VoucherBillDetail> BillDetails { get; set; }

        /// <summary>
        /// 扩展信息,JSON格式
        /// </summary>
        [JsonProperty("extend_info")]
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 券激活时间(券可以使用起始时间)
        /// </summary>
        [JsonProperty("gmt_active")]
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 券创建时间(券发券时间)
        /// </summary>
        [JsonProperty("gmt_create")]
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 券过期时间(券可以使用截止时间)
        /// </summary>
        [JsonProperty("gmt_expired")]
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 券名称(用户看到券名称)
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 券状态(ENABLED:可用,DISABLED:不可用,DELETE:删除状态,TRANS:发放中,TRANSFER:已转增,UNC:未领取,USED:已使用,USING:使用中,REFUNDED:已退款,REFUNDING:使用中,UNACTIVE:未激活,EXPIRED:已过期)
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板ID(模板唯一标识,创建模板返回)
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券面额(元)
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 券所属用户ID
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券ID(同入参券ID)
        /// </summary>
        [JsonProperty("voucher_id")]
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
