using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIotdeviceOnlinedataUploadModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIotdeviceOnlinedataUploadModel : AlipayObject
    {
        /// <summary>
        /// 设备有效时长（小于等于86400秒）
        /// </summary>
        [JsonPropertyName("device_online_time")]
        public long DeviceOnlineTime { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备对应政策类型(无政策(NO_POLICY),现金返佣(CASH_POLICY),屏幕共享(SHAREING_POLICY))
        /// </summary>
        [JsonPropertyName("policy_type")]
        public string PolicyType { get; set; }

        /// <summary>
        /// 结算支付宝账号：结算支付宝账号（商户）、结算支付宝账号（服务商）
        /// </summary>
        [JsonPropertyName("settled_alipay_id")]
        public string SettledAlipayId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 签约支付宝账号PID(2088开头): 商家支付宝账号（用于与蚂蚁签约的支付宝账号）、 外部服务商支付宝账号（用于与蚂蚁签约的支付宝账号）
        /// </summary>
        [JsonPropertyName("signed_alipay_id")]
        public string SignedAlipayId { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [JsonPropertyName("supplier_sn")]
        public string SupplierSn { get; set; }

        /// <summary>
        /// 上传日期
        /// </summary>
        [JsonPropertyName("upload_date")]
        public string UploadDate { get; set; }
    }
}
