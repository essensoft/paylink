using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StuffStockOutOrder Data Structure.
    /// </summary>
    public class StuffStockOutOrder : AlipayObject
    {
        /// <summary>
        /// 市编号
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区编号
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [JsonPropertyName("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// erp订单号
        /// </summary>
        [JsonPropertyName("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// erp订单类型
        /// </summary>
        [JsonPropertyName("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 出库单明细
        /// </summary>
        [JsonPropertyName("order_items")]
        public List<StuffStockOutOrderItem> OrderItems { get; set; }

        /// <summary>
        /// 省编号
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 收货方地址
        /// </summary>
        [JsonPropertyName("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收件方公司
        /// </summary>
        [JsonPropertyName("receiver_company")]
        public string ReceiverCompany { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [JsonPropertyName("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件方联系方式
        /// </summary>
        [JsonPropertyName("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收件方邮编
        /// </summary>
        [JsonPropertyName("receiver_zip_code")]
        public string ReceiverZipCode { get; set; }

        /// <summary>
        /// 顺丰订单类型
        /// </summary>
        [JsonPropertyName("sf_order_type")]
        public string SfOrderType { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
