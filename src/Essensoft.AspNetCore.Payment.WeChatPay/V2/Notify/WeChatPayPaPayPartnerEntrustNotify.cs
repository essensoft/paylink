using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Notify
{
    /// <summary>
    /// 微信代扣 - 签约、解约结果通知 (服务商)
    /// </summary>
    [XmlRoot("xml")]
    public class WeChatPayPaPayPartnerEntrustNotify : WeChatPayNotify
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
        /// 业务结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

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
        /// 签约协议号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户子标识
        /// </summary>
        [XmlElement("sub_openid")]
        public string SubOpenId { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 委托代扣协议id	
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 协议到期时间
        /// </summary>
        [XmlElement("contract_expired_time")]
        public string ContractExpiredTime { get; set; }

        /// <summary>
        /// 协议解约方式
        /// </summary>
        [XmlElement("contract_termination_mode")]
        public string ContractTerminationMode { get; set; }

        /// <summary>
        /// 请求序列号
        /// </summary>
        [XmlElement("request_serial")]
        public string RequestSerial { get; set; }
    }
}
