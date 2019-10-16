using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncArbillMonthstatementbillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncArbillMonthstatementbillQueryModel : AlipayObject
    {
        /// <summary>
        /// 分析维度1
        /// </summary>
        [JsonProperty("anl_dmsn_1_list")]
        public List<string> AnlDmsn1List { get; set; }

        /// <summary>
        /// 分析维度2
        /// </summary>
        [JsonProperty("anl_dmsn_2_list")]
        public List<string> AnlDmsn2List { get; set; }

        /// <summary>
        /// 分析维度3
        /// </summary>
        [JsonProperty("anl_dmsn_3_list")]
        public List<string> AnlDmsn3List { get; set; }

        /// <summary>
        /// 分析维度4
        /// </summary>
        [JsonProperty("anl_dmsn_4_list")]
        public List<string> AnlDmsn4List { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonProperty("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 账单月查询开始月份(包含, 必选)
        /// </summary>
        [JsonProperty("bill_month_begin")]
        public string BillMonthBegin { get; set; }

        /// <summary>
        /// 账单月查询截止月份(包含, 必选)
        /// </summary>
        [JsonProperty("bill_month_end")]
        public string BillMonthEnd { get; set; }

        /// <summary>
        /// 收费项编码
        /// </summary>
        [JsonProperty("charge_itme_code")]
        public string ChargeItmeCode { get; set; }

        /// <summary>
        /// 01:账单生成 02:待确认出账 03:已出账 04:客户已对账 05:对账差异 06:部分出账 07:账单出账中
        /// </summary>
        [JsonProperty("check_state")]
        public List<string> CheckState { get; set; }

        /// <summary>
        /// 业务扩展查询维度值,json格式
        /// </summary>
        [JsonProperty("dmsn_query_list")]
        public List<Pair> DmsnQueryList { get; set; }

        /// <summary>
        /// 数据来源,租户ID
        /// </summary>
        [JsonProperty("env_source")]
        public string EnvSource { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonProperty("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票状态 01:未开票 02:部分开票 03:完全开票
        /// </summary>
        [JsonProperty("invoice_status")]
        public List<string> InvoiceStatus { get; set; }

        /// <summary>
        /// 结算对象（MID） 和ipRoleId 二选一
        /// </summary>
        [JsonProperty("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 结算对象（PID） 和ipId 二选一
        /// </summary>
        [JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 起始页，分页时必须提供
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页显示数，分页时必须提供
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 对账状态 01:待结算 02:部分结算 03:结算完成
        /// </summary>
        [JsonProperty("pay_status_list")]
        public List<string> PayStatusList { get; set; }

        /// <summary>
        /// 付款方式  1资金  5走量
        /// </summary>
        [JsonProperty("pay_way_list")]
        public List<string> PayWayList { get; set; }

        /// <summary>
        /// 产品码,对于金融云为商品
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 结算周期 01:年结 02:季结 03:月结
        /// </summary>
        [JsonProperty("settle_period")]
        public List<string> SettlePeriod { get; set; }

        /// <summary>
        /// 结算方式 01:实时 02:预收, 03:后收 04:周期结算, 05:按日汇总结算, 06:周期结算, 09:延期结算, 10:无需结算, 11:业务自主结算, 12:自动周期结算
        /// </summary>
        [JsonProperty("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 账单的类型 1应收，2返点，4递延
        /// </summary>
        [JsonProperty("type_list")]
        public List<string> TypeList { get; set; }
    }
}
