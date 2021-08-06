using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIotdeviceChangeModifyModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIotdeviceChangeModifyModel : AlipayObject
    {
        /// <summary>
        /// 设备SN（不可变更，作为匹配对应信息主键）
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 记录创建时间
        /// </summary>
        [JsonPropertyName("gmt_created")]
        public string GmtCreated { get; set; }

        /// <summary>
        /// 变更记录号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 政策类型：无政策(NO_POLICY),现金返佣(CASH_POLICY),屏幕共享(SHAREING_POLICY)
        /// </summary>
        [JsonPropertyName("policy_type")]
        public string PolicyType { get; set; }

        /// <summary>
        /// 结算支付宝账号：结算支付宝账号（商户）、结算支付宝账号（服务商）
        /// </summary>
        [JsonPropertyName("settled_alipay_id")]
        public string SettledAlipayId { get; set; }

        /// <summary>
        /// 店铺所在详细地址
        /// </summary>
        [JsonPropertyName("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 店铺所在市
        /// </summary>
        [JsonPropertyName("shop_city")]
        public string ShopCity { get; set; }

        /// <summary>
        /// 店铺所在区/县
        /// </summary>
        [JsonPropertyName("shop_district")]
        public string ShopDistrict { get; set; }

        /// <summary>
        /// 店铺行业,使用蚂蚁行业分类，可参考https://www.yuque.com/kangxia-ij2dr/kb/ybdoqb#ib45 注意：一级目录与行业使用"-"分隔
        /// </summary>
        [JsonPropertyName("shop_industry")]
        public string ShopIndustry { get; set; }

        /// <summary>
        /// 店铺纬度
        /// </summary>
        [JsonPropertyName("shop_latitude")]
        public string ShopLatitude { get; set; }

        /// <summary>
        /// 店铺联系人电话
        /// </summary>
        [JsonPropertyName("shop_linkman_mobile")]
        public string ShopLinkmanMobile { get; set; }

        /// <summary>
        /// 店铺联系人
        /// </summary>
        [JsonPropertyName("shop_linkman_name")]
        public string ShopLinkmanName { get; set; }

        /// <summary>
        /// 店铺经度
        /// </summary>
        [JsonPropertyName("shop_longitude")]
        public string ShopLongitude { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺营业时间(时间范围 00:00-24:00)
        /// </summary>
        [JsonPropertyName("shop_open_time")]
        public string ShopOpenTime { get; set; }

        /// <summary>
        /// 店铺所在省
        /// </summary>
        [JsonPropertyName("shop_province")]
        public string ShopProvince { get; set; }

        /// <summary>
        /// 签约支付宝PID（有效）(必须与原始设备签约账号一致 )
        /// </summary>
        [JsonPropertyName("signed_alipay_id")]
        public string SignedAlipayId { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [JsonPropertyName("supplier_sn")]
        public string SupplierSn { get; set; }
    }
}
