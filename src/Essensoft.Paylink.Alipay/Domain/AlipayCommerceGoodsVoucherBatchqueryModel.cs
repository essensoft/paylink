using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceGoodsVoucherBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceGoodsVoucherBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonPropertyName("goods_list")]
        public BizfmcgGoods GoodsList { get; set; }

        /// <summary>
        /// isvId
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
