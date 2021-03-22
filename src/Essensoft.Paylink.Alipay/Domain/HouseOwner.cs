using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HouseOwner Data Structure.
    /// </summary>
    public class HouseOwner : AlipayObject
    {
        /// <summary>
        /// 权证号（完整）
        /// </summary>
        [JsonPropertyName("house_cert_no")]
        public string HouseCertNo { get; set; }

        /// <summary>
        /// 权证类型。 enum (PREBUY_CERT-预购证, PROP_RIGHT_CERT-房地产权证, OTHER_RIGHT_CERT-他项权证, COMMRIGHT_CERT-房地产权共有（用）证, PRESERIAL_CERT-贷款抵押登记备案, PREGAGE_CERT-预购房抵押登记证, LANDTRADE_CERT-土地使用权转让证, CONTRACTNUM_CERT-商品房签约合同号, PREMONITORY_CERT-房地产预告登记证明, ABUILDINGGAGE_CERT-在建工程抵押登记证明, GAGEFORETELL_CERT-房地产抵押预告登记证明, COLLANDUSE_CERT-集体土地建设用地使用证, HOUSE_OWNERSHIP_CERT-房屋所有权证, STOCKCONTRACTNUM_CERT-二手房签约合同号, REALTY_OWNERSHIP_CERT-不动产权证书, MORTGAGE_REG_CERT-不动产抵押登记证明, ESTPROFORETELL_CERT-不动产预告登记证明, ESTPRODEMURRAL_CERT-不动产异议登记证明, LAND_SHARE_CERT-土地分摊凭证)
        /// </summary>
        [JsonPropertyName("house_cert_type")]
        public string HouseCertType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
