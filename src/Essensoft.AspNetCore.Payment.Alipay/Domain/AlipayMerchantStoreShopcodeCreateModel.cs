using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantStoreShopcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayMerchantStoreShopcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店类目ID，可通过类目查询接口获取。传入时请传入当前类目的叶子节点ID
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 地区编码
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 地理坐标-纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地理坐标-经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商户支付宝登录ID
        /// </summary>
        [JsonPropertyName("merchant_logon_id")]
        public string MerchantLogonId { get; set; }

        /// <summary>
        /// 服务商操作员ID，一般由服务商定义
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户手机号
        /// </summary>
        [JsonPropertyName("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门头照图片上传后返回的文件地址，由调用图片上传接口后生成并返回
        /// </summary>
        [JsonPropertyName("shop_front_photo")]
        public string ShopFrontPhoto { get; set; }

        /// <summary>
        /// 支付宝店铺ID。如果在创建门店码之前已经创建好了支付宝店铺，则可传入店铺ID。且如果传入了该字段，则需保证该shop_id归属于merchant_logon_id名下。
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 名店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号，可由外部应用生成，由英文、数字组成
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 间联商户PID，当间连服务商调用时为必选参数
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 门店码码值，当前只支持传1个
        /// </summary>
        [JsonPropertyName("tokens")]
        public List<string> Tokens { get; set; }
    }
}
