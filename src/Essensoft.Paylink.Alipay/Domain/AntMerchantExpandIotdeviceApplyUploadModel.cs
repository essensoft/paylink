using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIotdeviceApplyUploadModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIotdeviceApplyUploadModel : AlipayObject
    {
        /// <summary>
        /// 代申请商家支付宝账号PID(2088开头)
        /// </summary>
        [JsonPropertyName("agent_alipay_id")]
        public string AgentAlipayId { get; set; }

        /// <summary>
        /// 申请数量
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 申请类型:商家自申请SELF_APPLY、服务商代申请REP_APPLY
        /// </summary>
        [JsonPropertyName("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 订单关联设备信息
        /// </summary>
        [JsonPropertyName("devices")]
        public List<OrderDevice> Devices { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 设备ITEMID（由蚂蚁提供）
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 设备MI（由蚂蚁提供）
        /// </summary>
        [JsonPropertyName("mall_item_id")]
        public string MallItemId { get; set; }

        /// <summary>
        /// 设备名称（由蚂蚁提供）
        /// </summary>
        [JsonPropertyName("mall_name")]
        public string MallName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 作业支付宝账号PID(2088开头)，蚂蚁作业小二身份标识（内部工号）、服务商作业小二身份标识（支付宝账号）
        /// </summary>
        [JsonPropertyName("operated_alipay_id")]
        public string OperatedAlipayId { get; set; }

        /// <summary>
        /// 订单号：保证业务唯一性，订单号不能重复，重复以后会报错
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态(已安装FINISH_INSTALLED、已取消FINISH_CANCELLED)
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 政策类型：无政策(NO_POLICY),现金返佣(CASH_POLICY),屏幕共享(SHAREING_POLICY)
        /// </summary>
        [JsonPropertyName("policy_type")]
        public string PolicyType { get; set; }

        /// <summary>
        /// 收件地址详细地址
        /// </summary>
        [JsonPropertyName("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收件地址市
        /// </summary>
        [JsonPropertyName("receiver_city")]
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 收件地址区/县
        /// </summary>
        [JsonPropertyName("receiver_district")]
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [JsonPropertyName("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [JsonPropertyName("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件地址省
        /// </summary>
        [JsonPropertyName("receiver_province")]
        public string ReceiverProvince { get; set; }

        /// <summary>
        /// 结算支付宝账号：结算支付宝账号（商户）、结算支付宝账号（服务商）
        /// </summary>
        [JsonPropertyName("settled_alipay_id")]
        public string SettledAlipayId { get; set; }

        /// <summary>
        /// 订单关联店铺信息
        /// </summary>
        [JsonPropertyName("shop")]
        public OrderShop Shop { get; set; }

        /// <summary>
        /// 签约支付宝账号PID(2088开头): 商家支付宝账号（用于与蚂蚁签约的支付宝账号）、 外部服务商支付宝账号（用于与蚂蚁签约的支付宝账号）
        /// </summary>
        [JsonPropertyName("signed_alipay_id")]
        public string SignedAlipayId { get; set; }
    }
}
