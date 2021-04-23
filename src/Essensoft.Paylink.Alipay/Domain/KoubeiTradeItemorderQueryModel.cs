using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeItemorderQueryModel Data Structure.
    /// </summary>
    public class KoubeiTradeItemorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑订单号，可通过 <a href="https://opendocs.alipay.com/apis/api_1/koubei.trade.itemorder.buy">koubei.trade.itemorder.buy</a>(口碑商品交易购买接口)获取。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
