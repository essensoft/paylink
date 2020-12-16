using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceApplystatusQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceApplystatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的"商户品牌简称"。 如：肯德基：KFC
        /// </summary>
        [JsonPropertyName("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 待查询订单开票状态列表，各订单号间通过英文逗号分割，不限于支付宝体内交易订单号。如：20200520110046966071,20200520110046966072,20200520110046966073
        /// </summary>
        [JsonPropertyName("order_no_list")]
        public List<string> OrderNoList { get; set; }

        /// <summary>
        /// 定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的"商户门店简称"。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求："商户品牌简称+商户门店简称"作为确定商户及其下属机构的唯一标识，不可重复。
        /// </summary>
        [JsonPropertyName("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
