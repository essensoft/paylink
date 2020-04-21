using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketShopBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 表示接口查询门店的业务渠道限制：ALL、 POS、不传。不传代表只查询普通门店，传入POS代表只查询简易门店，传入ALL代表查询普通门店和简易门店。
        /// </summary>
        [JsonPropertyName("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 页码，第一页传入"1"，默认500个结果为一页。此参数必须是大于0的正整数，为0时将查询报错。
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }
    }
}
