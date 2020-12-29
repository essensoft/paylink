using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenSpBlueseaactivityCreateModel : AlipayObject
    {
        /// <summary>
        /// 详细地址。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 蓝海活动的场景，支持场景如下： 直连餐饮（BLUE_SEA_FOOD_APPLY）； 直连快消（BLUE_SEA_FMCG_APPLY）； 间连餐饮（BLUE_SEA_FOOD_INDIRECT_APPLY）； 间连快消（BLUE_SEA_FMCG_INDIRECT_APPLY）。
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 营业执照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("business_lic")]
        public string BusinessLic { get; set; }

        /// <summary>
        /// 城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 食品经营许可证，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("food_business_lic")]
        public string FoodBusinessLic { get; set; }

        /// <summary>
        /// 食品流通许可证，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("food_circulate_lic")]
        public string FoodCirculateLic { get; set; }

        /// <summary>
        /// 食品卫生许可证，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("food_health_lic")]
        public string FoodHealthLic { get; set; }

        /// <summary>
        /// 食品生产许可证，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("food_production_lic")]
        public string FoodProductionLic { get; set; }

        /// <summary>
        /// 餐饮服务许可证，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("food_service_lic")]
        public string FoodServiceLic { get; set; }

        /// <summary>
        /// 内景照，要求图片清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("indoor_pic")]
        public string IndoorPic { get; set; }

        /// <summary>
        /// 参与蓝海活动的商户支付宝账号，只有当参与直连蓝海活动场景（BLUE_SEA_FOOD_APPLY/BLUE_SEA_FMCG_APPLY）时必填，间连场景可空。
        /// </summary>
        [JsonPropertyName("merchant_logon")]
        public string MerchantLogon { get; set; }

        /// <summary>
        /// 省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门头照，要求图片清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("shop_entrance_pic")]
        public string ShopEntrancePic { get; set; }

        /// <summary>
        /// 参与蓝海活动的间连商户账号，只有当参与间连蓝海活动场景（BLUE_SEA_FOOD_INDIRECT_APPLY/BLUE_SEA_FMCG_INDIRECT_APPLY）时必填，直连场景可空。
        /// </summary>
        [JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 烟草专卖零售许可证，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg格式。 请传入图片上传接口  https://opendocs.alipay.com/apis/01ea4t  返回的的image_id。 该资质是否必传请参见<a href='https://opendocs.alipay.com/open/01hd83'>报名资质要求</a>。
        /// </summary>
        [JsonPropertyName("tobacco_lic")]
        public string TobaccoLic { get; set; }
    }
}
