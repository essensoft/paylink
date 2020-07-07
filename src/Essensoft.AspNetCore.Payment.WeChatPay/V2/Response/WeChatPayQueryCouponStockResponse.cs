using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Response
{
    [XmlRoot("xml")]
    public class WeChatPayQueryCouponStockResponse : WeChatPayResponse
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 应用号
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述	
        /// </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }

        /// <summary>
        /// 代金券批次id	
        /// </summary>
        [XmlElement("coupon_stock_id")]
        public string CouponStockId { get; set; }

        /// <summary>
        /// 代金券名称
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 代金券面额
        /// </summary>
        [XmlElement("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 代金券使用最低限额	
        /// </summary>
        [XmlElement("coupon_mininumn")]
        public string CouponMininumn { get; set; }

        /// <summary>
        /// 代金券批次状态	
        /// </summary>
        [XmlElement("coupon_stock_status")]
        public string CouponStockStatus { get; set; }

        /// <summary>
        /// 代金券数量	
        /// </summary>
        [XmlElement("coupon_total")]
        public string CouponTotal { get; set; }

        /// <summary>
        /// 代金券最大领取数量	
        /// </summary>
        [XmlElement("max_quota")]
        public string MaxQuota { get; set; }

        /// <summary>
        /// 代金券已经发送的数量	
        /// </summary>
        [XmlElement("is_send_num")]
        public string IsSendNum { get; set; }

        /// <summary>
        /// 生效开始时间	
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 生效结束时间	
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 创建时间	
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 代金券预算额度	
        /// </summary>
        [XmlElement("coupon_budget")]
        public string CouponBudget { get; set; }
    }
}
