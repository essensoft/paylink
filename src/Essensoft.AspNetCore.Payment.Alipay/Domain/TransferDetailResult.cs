using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TransferDetailResult Data Structure.
    /// </summary>
    [Serializable]
    public class TransferDetailResult : AlipayObject
    {
        /// <summary>
        /// 付款/收款账户。充值记录中是付款账户。提现、转账记录中是收款账户。支付宝名称及账号脱敏；银行账户的户名脱敏，银行账户显示银行名称+银行卡号后四位
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金来源/去向类型。在充值记录中，表示资金来源类型，在转账和提现类型中，表示去向类型
        /// </summary>
        [JsonProperty("fund_desc")]
        public string FundDesc { get; set; }

        /// <summary>
        /// 银行单据号。对账使用，无需脱敏
        /// </summary>
        [JsonProperty("instruction_id")]
        public string InstructionId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 业务订单号。该笔业务单据的唯一识别编号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 服务费金额
        /// </summary>
        [JsonProperty("service_fee")]
        public string ServiceFee { get; set; }

        /// <summary>
        /// 资金状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子类型。“充值类型”，普通充值、大额充值。“转账类型”，暂无实现。转账至支付宝账户、转账至银行卡、批量转账支付宝账户、批量转账至银行卡、批量付款。“提现类型”，暂无实现。普通提现、批量委托提现。对账使用，无需脱敏
        /// </summary>
        [JsonProperty("sub_type_desc")]
        public string SubTypeDesc { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonProperty("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 查询类型描述：充值、转账、提现
        /// </summary>
        [JsonProperty("type_desc")]
        public string TypeDesc { get; set; }
    }
}
