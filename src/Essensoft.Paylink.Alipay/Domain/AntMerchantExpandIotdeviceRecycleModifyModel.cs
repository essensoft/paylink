using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIotdeviceRecycleModifyModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIotdeviceRecycleModifyModel : AlipayObject
    {
        /// <summary>
        /// 设备SN
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 回收单创建时间
        /// </summary>
        [JsonPropertyName("gmt_created")]
        public string GmtCreated { get; set; }

        /// <summary>
        /// 最后一次更新的时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 安装订单编号
        /// </summary>
        [JsonPropertyName("install_order_id")]
        public string InstallOrderId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 回收订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 回收人电话
        /// </summary>
        [JsonPropertyName("recycle_mobile")]
        public string RecycleMobile { get; set; }

        /// <summary>
        /// 回收人姓名
        /// </summary>
        [JsonPropertyName("recycle_name")]
        public string RecycleName { get; set; }

        /// <summary>
        /// 解绑原因: 默认(DEFAULT), 设备丢失(DEVICE_LOSS), 店铺解除合作,设备回收到仓库(SHOP_CANCEL_COOPERATION))
        /// </summary>
        [JsonPropertyName("recycle_reason")]
        public string RecycleReason { get; set; }

        /// <summary>
        /// 报备人电话
        /// </summary>
        [JsonPropertyName("report_mobile")]
        public string ReportMobile { get; set; }

        /// <summary>
        /// 报备人姓名
        /// </summary>
        [JsonPropertyName("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 店铺联系人电话 说明：只做维保记录使用，不会变更设备对应的【店铺联系人电话】信息，如果设备信息变更需要使用变更接口服务
        /// </summary>
        [JsonPropertyName("shop_contact_mobile")]
        public string ShopContactMobile { get; set; }

        /// <summary>
        /// 店铺联系人姓名 说明：只做维保记录使用，不会变更设备对应的【店铺联系人姓名】信息，如果设备信息变更需要使用变更接口服务
        /// </summary>
        [JsonPropertyName("shop_contact_name")]
        public string ShopContactName { get; set; }

        /// <summary>
        /// 签约支付宝PID（有效）
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
