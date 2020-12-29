using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchBrandItems Data Structure.
    /// </summary>
    public class SearchBrandItems : AlipayObject
    {
        /// <summary>
        /// 品牌box状态
        /// </summary>
        [JsonPropertyName("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌box提报关键词
        /// </summary>
        [JsonPropertyName("brand_box_keywords")]
        public List<string> BrandBoxKeywords { get; set; }

        /// <summary>
        /// 品牌box提报模板id(一拖二或一拖四)
        /// </summary>
        [JsonPropertyName("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// [{"detail":{"index":1,"name":"搜索1","desc":"111","url":"alipays://platformapi/startapp?appId=2021001105610428","img":"http://mdgwdev.alipay.net/$%7Bafts_bizKey%7D/afts/img/A*_fm5T7bUXKEAAAAAAAAAAAAAAQAAAQ/original","blockType":"TINYAPP","serviceCode":"2020052521000303956478","bizId":"2021001105610428","subServiceCode":"","version":"2","materialId":"SM2020081901393333"},"key":"b6726dc0-e1ee-11ea-a2fa-65a874e15ce1"},{"detail":{"index":2,"name":"搜索2","desc":"222","url":"alipays://platformapi/startApp?appId=20000047&gotoLifeDetail=true&publicBizType=LIFE_APP&publicId=201114215452&sourceId=globalsearch","img":"http://mdgwdev.alipay.net/$%7Bafts_bizKey%7D/afts/img/A*Tcr1SovzsWAAAAAAAAAAAAAAAQAAAQ/original","blockType":"PUBLIC_SERVICE","serviceCode":"2020052521000303956478","bizId":"2021001105610428","subServiceCode":"","version":"2","materialId":"SM2020081901393334"},"key":"b6726dc1-e1ee-11ea-a2fa-65a874e15ce1"}]
        /// </summary>
        [JsonPropertyName("data")]
        public List<BrandBoxDetail> Data { get; set; }

        /// <summary>
        /// 品牌box提报merchant_type
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 搜索模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
