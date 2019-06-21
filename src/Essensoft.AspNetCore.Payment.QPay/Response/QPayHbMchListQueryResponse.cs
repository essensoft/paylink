using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Response
{
    [XmlRoot("xml")]
    public class QPayHbMchListQueryResponse : QPayResponse
    {
        /// <summary>
        /// 返回错误码，0表示成功。
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }

        /// <summary>
        /// 对应result的说明，Ok表示成功
        /// </summary>
        [XmlElement("res_info")]
        public string ResInfo { get; set; }

        /// <summary>
        /// 红包单号
        /// </summary>
        [XmlElement("listid")]
        public string ListId { get; set; }

        /// <summary>
        /// 状态
        /// 1: 已支付
        /// 2: 已抢完
        /// 3: 已过期
        /// 4: 已退款(含部分退款)
        /// </summary>
        [XmlElement("state")]
        public int State { get; set; }

        /// <summary>
        /// 红包总个数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 领取个数
        /// </summary>
        [XmlElement("recv_num")]
        public long RecvNum { get; set; }

        /// <summary>
        /// 红包总金额	
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 领取金额
        /// </summary>
        [XmlElement("recv_amount")]
        public long RecvAmount { get; set; }

        /// <summary>
        /// 领取详情数组
        /// </summary>
        [XmlElement("recv_details")]
        public string RecvDetails { get; set; }

        /// <summary>
        /// 领取人QQ
        /// </summary>
        [XmlElement("uin")]
        public string Uin { get; set; }
    }
}
