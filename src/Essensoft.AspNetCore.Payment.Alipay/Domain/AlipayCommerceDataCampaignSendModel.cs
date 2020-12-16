using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceDataCampaignSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceDataCampaignSendModel : AlipayObject
    {
        /// <summary>
        /// 本次交易获得集点方式。目前支持扫码点餐：scanOrder、蜻蜓刷脸支付：facePay、当面付：faceToFace、储值卡支付：valueCard、在线支付：online。如有其它渠道需要和支付宝约定
        /// </summary>
        [JsonPropertyName("camp_category")]
        public string CampCategory { get; set; }

        /// <summary>
        /// 集点渠道，标识本次集点的交易数据是否产生于支付宝端。其中支付宝，取值：alipay；其它渠道，取值：other
        /// </summary>
        [JsonPropertyName("camp_channel")]
        public string CampChannel { get; set; }

        /// <summary>
        /// 集点活动id，即商户调用集点活动配置接口后接口返回的camp_id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 集点时间。取值精确至秒，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("camp_time")]
        public string CampTime { get; set; }

        /// <summary>
        /// 单次交易跨周期标识，即一笔交易跨两个集点周期时，需要传入cross_cycle=true，支付宝会告知用户当前阶段集点任务已完成。如集点任务目标为9点，当前用户集7点，本次交易集4点，完成本阶段集点任务的同时，进入下阶段集点任务
        /// </summary>
        [JsonPropertyName("cross_cycle")]
        public string CrossCycle { get; set; }

        /// <summary>
        /// 本次交易集点数量
        /// </summary>
        [JsonPropertyName("cur_num")]
        public string CurNum { get; set; }

        /// <summary>
        /// 集点数据回流业务扩展字段，json数组格式。具体值需要和支付宝约定
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 集点数据回流流水号，用于做幂等控制
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 本阶段集点任务中已累计集点数量，即包含本次交易集点数的当前阶段已累计点数
        /// </summary>
        [JsonPropertyName("total_num")]
        public string TotalNum { get; set; }

        /// <summary>
        /// 本次集点交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 集点用户的支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
