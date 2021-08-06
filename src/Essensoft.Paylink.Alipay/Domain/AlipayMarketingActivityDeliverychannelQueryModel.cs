using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityDeliverychannelQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityDeliverychannelQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前服务商所代理的商户信息.  在查询可投放的渠道信息时，会使用商户信息来进行渠道权限、准入等条件的判断.  如果代理商户信息中的businessType为ISV模式.则默认使用当前操作人的信息作为商户信息
        /// </summary>
        [JsonPropertyName("belong_merchant_info")]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 展位码。  boothCode含义：boothCode表达的是某个渠道可以投放的展位码。例如：支付结果页PAY_RESULT  枚举值： PAY_RESULT：支付结果页。  后续新增可投放的展位后，会在文档中新增描述信息
        /// </summary>
        [JsonPropertyName("booth_code")]
        public string BoothCode { get; set; }

        /// <summary>
        /// 查询的页码。  特别说明： 页码从1开始。
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页查询的个数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
