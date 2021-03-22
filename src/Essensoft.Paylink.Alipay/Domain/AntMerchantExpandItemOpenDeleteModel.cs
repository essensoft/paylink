using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenDeleteModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemOpenDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商品ID，通过创建商品接口 https://opendocs.alipay.com/apis/api_4/ant.merchant.expand.item.open.create 获取。
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
