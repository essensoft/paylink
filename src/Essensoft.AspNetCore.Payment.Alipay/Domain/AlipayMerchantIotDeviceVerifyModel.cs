using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantIotDeviceVerifyModel Data Structure.
    /// </summary>
    public class AlipayMerchantIotDeviceVerifyModel : AlipayObject
    {
        /// <summary>
        /// 设备 ID ，device_id_type 为 ID 时填写。
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 可选方式 [ID,SN]。ID-使用biztid作为设备唯一识别标识；SN-使用supplier_id、device_sn联合作为设备唯一识别标识。由于不同机型的supplier_id不同，推荐使用 ID 。
        /// </summary>
        [JsonPropertyName("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 设备序列号 ，device_id_type 为 SN 时填写。需配合supplier_id使用。
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 商户类型，直连商户填写direct，间连商户填写indirect
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 直连场景填写商户收单pid，间连场景不填
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 直连场景不填，间连场景填写商户收单smid
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 设备供应商ID ，device_id_type 为 SN 时填写。需注意不同机型的供应商ID可能不同。
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
