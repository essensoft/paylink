using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CPBillResultSet Data Structure.
    /// </summary>
    [Serializable]
    public class CPBillResultSet : AlipayObject
    {
        /// <summary>
        /// 账期
        /// </summary>
        [JsonProperty("acct_period")]
        [XmlElement("acct_period")]
        public string AcctPeriod { get; set; }

        /// <summary>
        /// 应收金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonProperty("bill_entry_amount")]
        [XmlElement("bill_entry_amount")]
        public string BillEntryAmount { get; set; }

        /// <summary>
        /// 物业费账单应收明细条目ID
        /// </summary>
        [JsonProperty("bill_entry_id")]
        [XmlElement("bill_entry_id")]
        public string BillEntryId { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [JsonProperty("cost_type")]
        [XmlElement("cost_type")]
        public string CostType { get; set; }

        /// <summary>
        /// 缴费截止日期
        /// </summary>
        [JsonProperty("deadline")]
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 物业系统端房屋编号
        /// </summary>
        [JsonProperty("out_room_id")]
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 出账日期
        /// </summary>
        [JsonProperty("release_day")]
        [XmlElement("release_day")]
        public string ReleaseDay { get; set; }

        /// <summary>
        /// 房屋门牌地址
        /// </summary>
        [JsonProperty("room_address")]
        [XmlElement("room_address")]
        public string RoomAddress { get; set; }

        /// <summary>
        /// 账单条目当前状态，状态值：  FINISH_PAYMENT - 用户完成支付和销账  UNDER_PAYMENT - 账单锁定待用户完成支付  WAIT_PAYMENT - 待缴且未过缴费截止日期  OUT_OF_DATE - 未支付且已过缴费截止日期
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
