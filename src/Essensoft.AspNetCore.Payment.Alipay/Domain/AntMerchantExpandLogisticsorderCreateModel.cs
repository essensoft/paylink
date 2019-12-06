using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandLogisticsorderCreateModel Data Structure.
    /// </summary>
    public class AntMerchantExpandLogisticsorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息（键值对列表，有重复的键后者覆盖前者，建议唯一，以免出现不可预期的结果）
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 预约取件时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [JsonPropertyName("gmt_pick")]
        public string GmtPick { get; set; }

        /// <summary>
        /// 货物类型
        /// </summary>
        [JsonPropertyName("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 关联主订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商、平台商侧自己的业务订单单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务类型，由大写字母以及下划线组成，由支付宝分配
        /// </summary>
        [JsonPropertyName("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 物流金额（单位：分）
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// 收件详细地址
        /// </summary>
        [JsonPropertyName("receiver_addr")]
        public string ReceiverAddr { get; set; }

        /// <summary>
        /// 收件地址所在区
        /// </summary>
        [JsonPropertyName("receiver_area")]
        public string ReceiverArea { get; set; }

        /// <summary>
        /// 收件地址所在市
        /// </summary>
        [JsonPropertyName("receiver_city")]
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 收件地纬度
        /// </summary>
        [JsonPropertyName("receiver_latitude")]
        public string ReceiverLatitude { get; set; }

        /// <summary>
        /// 收件地经度
        /// </summary>
        [JsonPropertyName("receiver_longitude")]
        public string ReceiverLongitude { get; set; }

        /// <summary>
        /// 收件人名称
        /// </summary>
        [JsonPropertyName("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [JsonPropertyName("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收件地POI地址
        /// </summary>
        [JsonPropertyName("receiver_poi_addr")]
        public string ReceiverPoiAddr { get; set; }

        /// <summary>
        /// 收件地址所在省
        /// </summary>
        [JsonPropertyName("receiver_province")]
        public string ReceiverProvince { get; set; }

        /// <summary>
        /// 收件地街道
        /// </summary>
        [JsonPropertyName("receiver_street")]
        public string ReceiverStreet { get; set; }

        /// <summary>
        /// 寄件详细地址
        /// </summary>
        [JsonPropertyName("sender_addr")]
        public string SenderAddr { get; set; }

        /// <summary>
        /// 寄件地址所在区
        /// </summary>
        [JsonPropertyName("sender_area")]
        public string SenderArea { get; set; }

        /// <summary>
        /// 寄件地址所在市
        /// </summary>
        [JsonPropertyName("sender_city")]
        public string SenderCity { get; set; }

        /// <summary>
        /// 寄件地纬度
        /// </summary>
        [JsonPropertyName("sender_latitude")]
        public string SenderLatitude { get; set; }

        /// <summary>
        /// 寄件地经度
        /// </summary>
        [JsonPropertyName("sender_longitude")]
        public string SenderLongitude { get; set; }

        /// <summary>
        /// 寄件人名称
        /// </summary>
        [JsonPropertyName("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 寄件人电话
        /// </summary>
        [JsonPropertyName("sender_phone")]
        public string SenderPhone { get; set; }

        /// <summary>
        /// 寄件地POI地址
        /// </summary>
        [JsonPropertyName("sender_poi_addr")]
        public string SenderPoiAddr { get; set; }

        /// <summary>
        /// 寄件地址所在省
        /// </summary>
        [JsonPropertyName("sender_province")]
        public string SenderProvince { get; set; }

        /// <summary>
        /// 寄件地街道
        /// </summary>
        [JsonPropertyName("sender_street")]
        public string SenderStreet { get; set; }
    }
}
