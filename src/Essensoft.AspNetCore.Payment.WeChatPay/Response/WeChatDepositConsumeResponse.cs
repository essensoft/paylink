using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    /// <summary>
    /// 酒店押金消费接口响应结果
    /// </summary>
    [XmlRoot("xml")]
    public class WeChatDepositConsumeResponse : WeChatPayResponse
    {
        /// <summary>
        /// 返回状态码
        /// 此字段是通信标识，非交易标识，
        /// 交易是否成功需要查看result_code来判断
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息，如非空，为错误原因
        /// 签名失败
        /// 参数格式校验错误
        /// </summary>
        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        [XmlElement("sub_appid")]
        public string SubAppId { get; set; }

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
        /// 微信支付订单号	
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号	
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 标价金额		
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 消费金额	
        /// </summary>
        [XmlElement("consume_fee")]
        public string ConsumeFee { get; set; }

        /// <summary>
        /// 货币类型	
        /// </summary>
        [XmlElement("fee_type")]
        public string FeeType { get; set; }
    }
}
