using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Response
{
    [XmlRoot("xml")]
    public class WeChatPayGetHbInfoResponse : WeChatPayResponse
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
        /// 商户订单号
        /// </summary>
        [XmlElement("mch_billno")]
        public string MchBillNo { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 红包单号
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 红包状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 发放类型
        /// </summary>
        [XmlElement("send_type")]
        public string SendType { get; set; }

        /// <summary>
        /// 红包类型
        /// </summary>
        [XmlElement("hb_type")]
        public string HbType { get; set; }

        /// <summary>
        /// 红包个数
        /// </summary>
        [XmlElement("total_num")]
        public int TotalNum { get; set; }

        /// <summary>
        /// 红包金额
        /// </summary>
        [XmlElement("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 红包发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 红包退款时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 红包退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 祝福语
        /// </summary>
        [XmlElement("wishing")]
        public string Wishing { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("act_name")]
        public string ActName { get; set; }

        /// <summary>
        /// 裂变红包领取列表
        /// </summary>
        [XmlArray("hblist")]
        [XmlArrayItem("hbinfo")]
        public List<HbInfo> HbList { get; set; }
    }
}
