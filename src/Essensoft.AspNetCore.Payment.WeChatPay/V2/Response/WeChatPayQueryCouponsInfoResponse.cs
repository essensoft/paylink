using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Response
{
    [XmlRoot("xml")]
    public class WeChatPayQueryCouponsInfoResponse : WeChatPayResponse
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
        /// 子商户号
        /// </summary>
        [XmlElement("sub_mch_id")]
        public string SubMchId { get; set; }

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
        /// 批次ID	
        /// </summary>
        [XmlElement("coupon_stock_id")]
        public string CouponStockId { get; set; }

        /// <summary>
        /// 代金券id
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 代金券面额
        /// </summary>
        [XmlElement("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 代金券使用门槛	
        /// </summary>
        [XmlElement("coupon_mininumn")]
        public string CouponMininumn { get; set; }

        /// <summary>
        /// 代金券名称
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 代金券状态	
        /// </summary>
        [XmlElement("coupon_state")]
        public string CouponState { get; set; }

        /// <summary>
        /// 代金券描述	
        /// </summary>
        [XmlElement("coupon_desc")]
        public string CouponDesc { get; set; }

        /// <summary>
        /// 实际优惠金额	
        /// </summary>
        [XmlElement("coupon_use_value")]
        public string CouponUseValue { get; set; }

        /// <summary>
        /// 优惠剩余可用额	
        /// </summary>
        [XmlElement("coupon_remain_value")]
        public string CouponRemainValue { get; set; }

        /// <summary>
        /// 发放来源	
        /// </summary>
        [XmlElement("send_source")]
        public string SendSource { get; set; }

        /// <summary>
        /// 是否允许部分使用	
        /// </summary>
        [XmlElement("is_partial_use")]
        public string IsPartialUse { get; set; }
    }
}
