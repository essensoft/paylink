using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIsvDeviceBindModel : AlipayObject
    {
        /// <summary>
        /// 机具使用场景：  团餐：CATERING_DEVICE；  快消：FMCG_DEVICE
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 设备编号。由各个供应商自己定义的设备标识，和供应商编号确定设备的唯一性
        /// </summary>
        [JsonProperty("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 物料模板id，每个物料模板对应的唯一标识，由蚂蚁金服物料平台管理
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 开放平台机具申请单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 门店id。ISV为商家创建的门店对应的唯一标识
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 供应商编号。由蚂蚁金服为每个供应商分配的唯一标识
        /// </summary>
        [JsonProperty("supplier_no")]
        public string SupplierNo { get; set; }
    }
}
