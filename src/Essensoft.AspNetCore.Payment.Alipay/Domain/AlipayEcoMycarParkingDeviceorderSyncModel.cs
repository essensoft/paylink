using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingDeviceorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingDeviceorderSyncModel : AlipayObject
    {
        /// <summary>
        /// 停车场ID
        /// </summary>
        [JsonProperty("alipay_parking_id")]
        public string AlipayParkingId { get; set; }

        /// <summary>
        /// 支付宝IoT平台分配的供应商序列号  关键信息，支付宝强校验
        /// </summary>
        [JsonProperty("alipay_supplier_sn")]
        public string AlipaySupplierSn { get; set; }

        /// <summary>
        /// 申请人支付宝账号
        /// </summary>
        [JsonProperty("applicant_alipay_account")]
        public string ApplicantAlipayAccount { get; set; }

        /// <summary>
        /// 申请人姓名
        /// </summary>
        [JsonProperty("applicant_name")]
        public string ApplicantName { get; set; }

        /// <summary>
        /// 申请人联系方式
        /// </summary>
        [JsonProperty("applicant_phone")]
        public string ApplicantPhone { get; set; }

        /// <summary>
        /// 变更到当前状态的业务时间，注意非数据回流时间
        /// </summary>
        [JsonProperty("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 岗亭数量
        /// </summary>
        [JsonProperty("booth_num")]
        public string BoothNum { get; set; }

        /// <summary>
        /// 申请设备数量
        /// </summary>
        [JsonProperty("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 申请设备类型。键信息，设备型号需在支付宝IoT平台已注册。支付宝根据厂商供应商sn+厂商设备型号进行强校验
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 机具订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态:  1. APPLYING 申请中   2. AUDITING 审核中   3. AUDIT_REJECTED 审核未通过  4. WAIT_DELIVERY 待发货  5. DELIVERED 待收货   6. RECEIVED 已收货  7. CANCELLED 已撤销    order_state=APPLYING时，除了remark外的其余字段也需传入
        /// </summary>
        [JsonProperty("order_state")]
        public string OrderState { get; set; }

        /// <summary>
        /// 车场负责人姓名
        /// </summary>
        [JsonProperty("pklot_principal_name")]
        public string PklotPrincipalName { get; set; }

        /// <summary>
        /// 车场负责人联系方式
        /// </summary>
        [JsonProperty("pklot_principal_phone")]
        public string PklotPrincipalPhone { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [JsonProperty("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonProperty("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人联系方式
        /// </summary>
        [JsonProperty("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }
    }
}
