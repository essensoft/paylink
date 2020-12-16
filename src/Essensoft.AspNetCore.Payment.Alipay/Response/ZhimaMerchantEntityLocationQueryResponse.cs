using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantEntityLocationQueryResponse.
    /// </summary>
    public class ZhimaMerchantEntityLocationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充电宝位置
        /// </summary>
        [JsonPropertyName("address_desc")]
        public string AddressDesc { get; set; }

        /// <summary>
        /// 充电宝小程序的链接
        /// </summary>
        [JsonPropertyName("applet_link")]
        public string AppletLink { get; set; }

        /// <summary>
        /// 充电宝的品牌
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 是否存在
        /// </summary>
        [JsonPropertyName("exist")]
        public bool Exist { get; set; }

        /// <summary>
        /// h5链接
        /// </summary>
        [JsonPropertyName("h_five_link")]
        public string HFiveLink { get; set; }

        /// <summary>
        /// 充电宝支持的接口类型
        /// </summary>
        [JsonPropertyName("interface_type")]
        public string InterfaceType { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 充电宝充电价格
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 支付宝配置的文案
        /// </summary>
        [JsonPropertyName("zfb_text_content")]
        public string ZfbTextContent { get; set; }
    }
}
