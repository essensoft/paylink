using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SupplierAssetResponse Data Structure.
    /// </summary>
    public class SupplierAssetResponse : AlipayObject
    {
        /// <summary>
        /// 审核备注
        /// </summary>
        [JsonPropertyName("approval_remark")]
        public string ApprovalRemark { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonPropertyName("approval_status")]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// 审核状态文案
        /// </summary>
        [JsonPropertyName("approval_status_text")]
        public string ApprovalStatusText { get; set; }

        /// <summary>
        /// 是否支持蓝牙
        /// </summary>
        [JsonPropertyName("bluetooth_mode")]
        public string BluetoothMode { get; set; }

        /// <summary>
        /// bluetooth mode文案
        /// </summary>
        [JsonPropertyName("bluetooth_mode_text")]
        public string BluetoothModeText { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [JsonPropertyName("contact_address")]
        public string ContactAddress { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 设备CPU
        /// </summary>
        [JsonPropertyName("cpu")]
        public string Cpu { get; set; }

        /// <summary>
        /// 产品设计图片
        /// </summary>
        [JsonPropertyName("device_design_img")]
        public string DeviceDesignImg { get; set; }

        /// <summary>
        /// 产品设计图id
        /// </summary>
        [JsonPropertyName("device_design_img_id")]
        public string DeviceDesignImgId { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        [JsonPropertyName("device_img")]
        public string DeviceImg { get; set; }

        /// <summary>
        /// 产品图片id
        /// </summary>
        [JsonPropertyName("device_img_id")]
        public string DeviceImgId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonPropertyName("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备其他说明
        /// </summary>
        [JsonPropertyName("device_other_desc")]
        public string DeviceOtherDesc { get; set; }

        /// <summary>
        /// 人脸摄像头
        /// </summary>
        [JsonPropertyName("face_camera")]
        public string FaceCamera { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 记录主键id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料id（蚂蚁设备id）
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 是否支持有线网络
        /// </summary>
        [JsonPropertyName("line_network_mode")]
        public string LineNetworkMode { get; set; }

        /// <summary>
        /// line network mode文案
        /// </summary>
        [JsonPropertyName("line_network_mode_text")]
        public string LineNetworkModeText { get; set; }

        /// <summary>
        /// 设备内存
        /// </summary>
        [JsonPropertyName("memory")]
        public string Memory { get; set; }

        /// <summary>
        /// 最低系统版本
        /// </summary>
        [JsonPropertyName("min_os_version")]
        public string MinOsVersion { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("model_number")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// 是否支持移动网络
        /// </summary>
        [JsonPropertyName("network_mode")]
        public string NetworkMode { get; set; }

        /// <summary>
        /// network mode文案
        /// </summary>
        [JsonPropertyName("network_mode_text")]
        public string NetworkModeText { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [JsonPropertyName("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// 是否支持打印机
        /// </summary>
        [JsonPropertyName("printer")]
        public string Printer { get; set; }

        /// <summary>
        /// ram大小
        /// </summary>
        [JsonPropertyName("ram")]
        public long Ram { get; set; }

        /// <summary>
        /// rom大小
        /// </summary>
        [JsonPropertyName("rom")]
        public long Rom { get; set; }

        /// <summary>
        /// 扫码方式
        /// </summary>
        [JsonPropertyName("scan_code_mode")]
        public string ScanCodeMode { get; set; }

        /// <summary>
        /// 扫码距离
        /// </summary>
        [JsonPropertyName("scan_code_read_dista")]
        public string ScanCodeReadDista { get; set; }

        /// <summary>
        /// 显示屏分辨率
        /// </summary>
        [JsonPropertyName("screen_dpi")]
        public string ScreenDpi { get; set; }

        /// <summary>
        /// 屏幕尺寸
        /// </summary>
        [JsonPropertyName("screen_size")]
        public string ScreenSize { get; set; }

        /// <summary>
        /// sdk自动打包文件下载地址
        /// </summary>
        [JsonPropertyName("sdk_auto_file")]
        public string SdkAutoFile { get; set; }

        /// <summary>
        /// sdk文件id
        /// </summary>
        [JsonPropertyName("sdk_auto_file_id")]
        public string SdkAutoFileId { get; set; }

        /// <summary>
        /// sdk名称
        /// </summary>
        [JsonPropertyName("sdk_name")]
        public string SdkName { get; set; }

        /// <summary>
        /// sdk版本号
        /// </summary>
        [JsonPropertyName("sdk_version")]
        public string SdkVersion { get; set; }

        /// <summary>
        /// 设备存储
        /// </summary>
        [JsonPropertyName("storage")]
        public string Storage { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [JsonPropertyName("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 供应商pid
        /// </summary>
        [JsonPropertyName("supplier_pid")]
        public string SupplierPid { get; set; }

        /// <summary>
        /// 供应商sn
        /// </summary>
        [JsonPropertyName("supplier_sn")]
        public string SupplierSn { get; set; }

        /// <summary>
        /// 设备交易模式，ONE/ZERO
        /// </summary>
        [JsonPropertyName("tranaction_model")]
        public string TranactionModel { get; set; }

        /// <summary>
        /// tranaction model文案
        /// </summary>
        [JsonPropertyName("tranaction_model_text")]
        public string TranactionModelText { get; set; }

        /// <summary>
        /// 是否支持wifi
        /// </summary>
        [JsonPropertyName("wifi_mode")]
        public string WifiMode { get; set; }

        /// <summary>
        /// wifi mode文案
        /// </summary>
        [JsonPropertyName("wifi_mode_text")]
        public string WifiModeText { get; set; }
    }
}
