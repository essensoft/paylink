using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopQueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 地址。商户详细经营地址或人员所在地点。
        /// </summary>
        [JsonPropertyName("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [JsonPropertyName("enterprise_city")]
        public string EnterpriseCity { get; set; }

        /// <summary>
        /// 区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [JsonPropertyName("enterprise_district")]
        public string EnterpriseDistrict { get; set; }

        /// <summary>
        /// 省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [JsonPropertyName("enterprise_province")]
        public string EnterpriseProvince { get; set; }

        /// <summary>
        /// 纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 在配送公司的门店状态。
        /// </summary>
        [JsonPropertyName("logistics_shop_status")]
        public List<LogisticsShopStatusDTO> LogisticsShopStatus { get; set; }

        /// <summary>
        /// 经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 联系人电话/手机号。
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 高德poiid
        /// </summary>
        [JsonPropertyName("poiid")]
        public string Poiid { get; set; }

        /// <summary>
        /// 店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目
        /// </summary>
        [JsonPropertyName("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 门店名称，最长不超过256个字符
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商家门店编码。
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }
    }
}
