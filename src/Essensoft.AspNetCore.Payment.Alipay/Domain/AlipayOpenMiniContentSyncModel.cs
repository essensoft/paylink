using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniContentSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniContentSyncModel : AlipayObject
    {
        /// <summary>
        /// 具体的内容数据，采用json格式，不同类型不同操作数据不同，请根据 https://opendocs.alipay.com/mini/00ntj5内容同步产品文档，选择需接入功能并传入对应参数。
        /// </summary>
        [JsonPropertyName("content_data")]
        public string ContentData { get; set; }

        /// <summary>
        /// 内容类型，例如门店、商品等。枚举支持： ITEM：导入、更新、下架商品时使用。 SHOP：门店解除绑定时使用。 SERVICE：服务绑定、解绑分门店/POI、分页查询绑定关系时使用。
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 扩展信息，json格式。请根据 https://opendocs.alipay.com/mini/00ntj5内容同步产品文档，选择需接入功能并传入对应参数。
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 内容类型下的具体操作，比如门店类型下，小程序批量绑定门店。枚举支持： sync：导入或更新商品时使用。 invalid：下架商品时使用。 batchUnbind：解绑门店时使用。 batchBind：小程序服务绑定绑定门店/POI时使用。 batchUnbinding：小程序服务解绑门店/POI时使用。 pageQueryBindingInfo：分页查询小程序服务绑定门店/POI关系时使用。 详情可参考https://opendocs.alipay.com/mini/00ntj5内容同步产品文档。
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }
    }
}
