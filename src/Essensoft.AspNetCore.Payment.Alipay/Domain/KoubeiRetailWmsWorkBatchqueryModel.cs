using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsWorkBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsWorkBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 完成时间范围开始时间
        /// </summary>
        [JsonProperty("gmt_finished_from")]
        public string GmtFinishedFrom { get; set; }

        /// <summary>
        /// 完成时间范围结束时间
        /// </summary>
        [JsonProperty("gmt_finished_to")]
        public string GmtFinishedTo { get; set; }

        /// <summary>
        /// 作业对应的入库/出库通知单的外部业务单据号，这个单据可能是采购单、补货单等
        /// </summary>
        [JsonProperty("notice_out_biz_no")]
        public string NoticeOutBizNo { get; set; }

        /// <summary>
        /// 作业对应的通知单的外部业务类型，BHRK=补货入库，CGRK=采购入库，CGTHRK=采购退货入库，DDTHRK=订单退货入库，PDRK=盘点入库，CGCK=采购出库，DDCK=订单出库，PDCK=盘点出库，BHCK=补货出库
        /// </summary>
        [JsonProperty("notice_out_biz_type")]
        public string NoticeOutBizType { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 页码，从1开始，不传默认为1
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，不传默认20，不能超过100
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 作业状态，INIT=待提交，FINISHED=已完成
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 作业类型，INBOUND=入库，OUTBOUND=出库
        /// </summary>
        [JsonProperty("work_type")]
        public string WorkType { get; set; }
    }
}
