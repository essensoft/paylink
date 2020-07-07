using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Response
{
    [XmlRoot("xml")]
    public class WeChatPayPaPayPartnerQueryContractResponse : WeChatPayResponse
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
        /// 应用号
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 子商户应用号
        /// </summary>
        [XmlElement("sub_appid")]
        public string SubAppId { get; set; }

        /// <summary>
        /// 委托代扣协议id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 请求序列号
        /// </summary>
        [XmlElement("request_serial")]
        public string RequestSerial { get; set; }

        /// <summary>
        /// 签约协议号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 用户账户展示名称
        /// </summary>
        [XmlElement("contract_display_account")]
        public string ContractDisplayAccount { get; set; }

        /// <summary>
        /// 协议状态
        /// </summary>
        [XmlElement("contract_state")]
        public string ContractState { get; set; }

        /// <summary>
        /// 协议签署时间
        /// </summary>
        [XmlElement("contract_signed_time")]
        public string ContractSignedTime { get; set; }

        /// <summary>
        /// 协议到期时间
        /// </summary>
        [XmlElement("contract_expired_time")]
        public string ContractExpiredTime { get; set; }

        /// <summary>
        /// 协议解约时间
        /// </summary>
        [XmlElement("contract_terminated_time")]
        public string ContractTerminatedTime { get; set; }

        /// <summary>
        /// 协议解约方式
        /// </summary>
        [XmlElement("contract_termination_mode")]
        public string ContractTerminationMode { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 解约备注
        /// </summary>
        [XmlElement("contract_termination_remark")]
        public string ContractTerminationRemark { get; set; }

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
        /// 错误代码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述	
        /// </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }
    }
}
