using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarCarmodelModifyModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarCarmodelModifyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝车型库品牌背景图片，尺寸750 x 448（modify_type参数的值为brand时此参数必填）图片url可以通过【通用图片上传接口】alipay.eco.mycar.image.upload 上传完成后获取, 图片url需要进行URLencode进行转码
        /// </summary>
        [JsonPropertyName("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// 支付宝车型库品牌编号（系统唯一），品牌编号可以通过调用【批量查询车型信息接口】alipay.eco.mycar.carmodel.batchquery 获取。（modify_type参数的值为brand时此参数必填）
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 支付宝车型库品牌图片，尺寸220 x 147 （modify_type参数的值为brand时此参数必填）品牌图片url可以通过【通用图片上传接口】alipay.eco.mycar.image.upload上传完成后获取, 图片url需要进行URLencode进行转码
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 支付宝车型库品牌名称（add_type参数的值为brand时此参数必填）开发者自行配置，保证系统唯一
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 支付宝车型库排量（modify_type参数的值为model时此参数必填）
        /// </summary>
        [JsonPropertyName("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// 支付宝车型库厂商编号（系统唯一），厂商编号可以通过调用【批量查询车型信息接口】alipay.eco.mycar.carmodel.batchquery 获取。（modify_type参数的值为company时此参数必填）
        /// </summary>
        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 支付宝车型库厂商名称（modify_type参数的值为company时此参数必填）
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 支付宝车型库发动机型号（modify_type参数的值为model时此参数必填）
        /// </summary>
        [JsonPropertyName("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// 支付宝车型库车型编号（系统唯一），可以通过调用【批量查询车型信息接口】alipay.eco.mycar.carmodel.batchquery 获取。（modify_type参数的值为model时此参数必填）
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 支付宝车型库车型名称（modify_type参数的值为model时此参数必填）
        /// </summary>
        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 修改类型，接口通过此参数判断本次请求是修改品牌信息还是车型信息等，brand（品牌），company（厂商），serie（车系），model（车型）
        /// </summary>
        [JsonPropertyName("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 支付宝车型库生产年份（modify_type参数的值为model时此参数必填）
        /// </summary>
        [JsonPropertyName("prod_year")]
        public string ProdYear { get; set; }

        /// <summary>
        /// 支付宝车型库车系组名称（add_type":"serie状态时必填）
        /// </summary>
        [JsonPropertyName("serie_group")]
        public string SerieGroup { get; set; }

        /// <summary>
        /// 支付宝车型库车系编号（系统唯一），车系编号可以通过调用【批量查询车型信息接口】alipay.eco.mycar.carmodel.batchquery 获取。（modify_type参数的值为serie时此参数必填）
        /// </summary>
        [JsonPropertyName("serie_id")]
        public string SerieId { get; set; }

        /// <summary>
        /// 支付宝车型库车系名称（modify_type参数的值为serie时此参数必填）
        /// </summary>
        [JsonPropertyName("serie_name")]
        public string SerieName { get; set; }

        /// <summary>
        /// 支付宝车型库车系logo图片链接地址，尺寸220 x 147 （modify_type参数的值为serie时此参数必填）图片url可以通过【通用图片上传接口】alipay.eco.mycar.image.upload 上传完成后获取,图片url需要进行URLencode进行转码
        /// </summary>
        [JsonPropertyName("serie_photo")]
        public string SeriePhoto { get; set; }

        /// <summary>
        /// 支付宝车型库年款（modify_type参数的值为model时此参数必填）
        /// </summary>
        [JsonPropertyName("style")]
        public string Style { get; set; }
    }
}
