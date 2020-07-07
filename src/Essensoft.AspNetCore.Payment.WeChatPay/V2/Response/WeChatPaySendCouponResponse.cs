using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Response
{
    [XmlRoot("xml")]
    public class WeChatPaySendCouponResponse : WeChatPayResponse
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
        /// 返回记录数	
        /// </summary>
        [XmlElement("resp_count")]
        public string RespCount { get; set; }

        /// <summary>
        /// 成功记录数	
        /// </summary>
        [XmlElement("success_count")]
        public string SuccessCount { get; set; }

        /// <summary>
        /// 失败记录数	
        /// </summary>
        [XmlElement("failed_count")]
        public string FailedCount { get; set; }

        /// <summary>
        /// 用户标识	
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 返回码	
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 代金券id	
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 返回信息	
        /// </summary>
        [XmlElement("ret_msg")]
        public string RetMsg { get; set; }
    }
}
