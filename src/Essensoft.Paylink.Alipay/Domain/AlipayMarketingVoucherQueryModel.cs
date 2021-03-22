using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherQueryModel : AlipayObject
    {
        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)。通过 <a  href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.voucher.send">alipay.marketing.voucher.send(发券接口)发券后获取。
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
