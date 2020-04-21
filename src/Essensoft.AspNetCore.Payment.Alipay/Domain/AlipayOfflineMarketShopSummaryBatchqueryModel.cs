using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopSummaryBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketShopSummaryBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 表示接口查询门店的业务渠道限制：ALL、 POS、不传。不传代表只查询普通门店，传入POS代表只查询简易门店，传入ALL代表查询普通门店和简易门店。
        /// </summary>
        [JsonPropertyName("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 城市编码，国标码，如：120100表示天津市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区域编码，如：120104表示南开区
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 表示接口业务的调用方身份：ISV、 服务商身份标识。传入ISV代表系统集成商身份。传入PROVIDER代表服务商。
        /// </summary>
        [JsonPropertyName("op_role")]
        public string OpRole { get; set; }

        /// <summary>
        /// 页码，留空标示第一页，默认 20个结果为一页
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页记录数，默认20，最大 100
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 省份编码，国标码，如：120000表示天津
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店数据查询类型，根据类型可以返回指定的门店数据，目前支持的类型如下：  BRAND_RELATION ： 品牌商关联店铺  MALL_SELF ：MALL自己的门店  MALL_RELATION：MALL关联下的门店  MERCHANT_SELF:商户自己的门店  KB_PROMOTER：口碑客推广者
        /// </summary>
        [JsonPropertyName("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// query_type查询类型下所关联的商户PID
        /// </summary>
        [JsonPropertyName("related_partner_id")]
        public string RelatedPartnerId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店状态，传入多个状态，多个状态使用英文逗号隔开，例如：PAUSED,OPEN  店铺状态：OPEN（营业）、PAUSED（暂停）、INIT（初始）、FREEZE（冻结）、CLOSED（关店）
        /// </summary>
        [JsonPropertyName("shop_status")]
        public string ShopStatus { get; set; }
    }
}
