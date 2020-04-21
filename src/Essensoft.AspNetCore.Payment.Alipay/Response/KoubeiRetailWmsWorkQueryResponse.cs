using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsWorkQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsWorkQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 作业完成时间，未完成则该值为空
        /// </summary>
        [JsonPropertyName("gmt_finished")]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 作业对应的入库/出库通知单的外部业务单据号，这个单据可能是采购单、补货单等
        /// </summary>
        [JsonPropertyName("notice_out_biz_no")]
        public string NoticeOutBizNo { get; set; }

        /// <summary>
        /// 作业对应的通知单的外部业务类型，BHRK=补货入库，CGRK=采购入库，CGTHRK=采购退货入库，DDTHRK=订单退货入库，PDRK=盘点入库，CGCK=采购出库，DDCK=订单出库，PDCK=盘点出库，BHCK=补货出库
        /// </summary>
        [JsonPropertyName("notice_out_biz_type")]
        public string NoticeOutBizType { get; set; }

        /// <summary>
        /// 操作员id
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 与作业相关的外部单据号，如菜鸟发货id
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 作业单状态 INIT=初始状态，FINISHED=完成状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 作业明细模型列表
        /// </summary>
        [JsonPropertyName("work_details")]
        public List<WorkDetail> WorkDetails { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [JsonPropertyName("work_id")]
        public string WorkId { get; set; }
    }
}
