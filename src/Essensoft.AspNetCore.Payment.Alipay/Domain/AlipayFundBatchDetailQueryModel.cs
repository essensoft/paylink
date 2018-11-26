using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundBatchDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundBatchDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 11～32位的数字或字母或数字与字母的组合，且区分大小写。
        /// </summary>
        [JsonProperty("batch_no")]
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批量代发到支付宝账户：BATCH_TRANS_ACC  批量代发到银行账户：BATCH_TRANS_BC
        /// </summary>
        [JsonProperty("biz_code")]
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 批量代发业务场景。  GLOBAL: 全球代发. 除CNY的多币种代发或人民币跨境代发。  LOCAL：中国境内纯人民币代发。
        /// </summary>
        [JsonProperty("biz_scene")]
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 批次文件中明细流水号
        /// </summary>
        [JsonProperty("detail_no")]
        [XmlElement("detail_no")]
        public string DetailNo { get; set; }

        /// <summary>
        /// INIT：支付宝只对上传的文件做了记录，还没有处理。  APPLIED：支付宝已完成兑换，等待发起付汇。  DEALED：已发起付汇申请，等待付汇结果。  SUCCESS 处理成功：付汇成功。  FAIL 处理失败：明细信息错误导致明细校验失败或者付汇失败。  DISUSE 已废弃：明细被支付宝系统废弃。
        /// </summary>
        [JsonProperty("detail_status")]
        [XmlElement("detail_status")]
        public string DetailStatus { get; set; }

        /// <summary>
        /// 采用分页查询，本参数为空或0默认显示第一页。每页最大500条记录，不足500条则按实际记录数返回，不需要商户输入每页的记录数。如果输入的值大于总页数，则支付宝返回最后一页数据。  例如：按条件查询到600条数据，则分成2页显示。输入2或大于2的整数都会返回100条数据；不输入任何数据则默认返回第一页。
        /// </summary>
        [JsonProperty("page_num")]
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 收款方账号。对于批量代发到支付宝账户场景，填写钱包账号。对于批量代发到银行账户场景，填写银行卡号。
        /// </summary>
        [JsonProperty("payee_account")]
        [XmlElement("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 签约主体，即签约了批量代发产品的支付宝账号。
        /// </summary>
        [JsonProperty("sign_principal")]
        [XmlElement("sign_principal")]
        public string SignPrincipal { get; set; }
    }
}
