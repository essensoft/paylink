using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PackageItemOpenInfo Data Structure.
    /// </summary>
    public class PackageItemOpenInfo : AlipayObject
    {
        /// <summary>
        /// 账单数据
        /// </summary>
        [JsonPropertyName("consume_output_info")]
        public ConsumeOutputInfo ConsumeOutputInfo { get; set; }

        /// <summary>
        /// 发票文件下载链接
        /// </summary>
        [JsonPropertyName("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 文件类型，如pdf，ofd，jpg
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 电子发票的数据
        /// </summary>
        [JsonPropertyName("invoice_output_info")]
        public InvoiceOutputInfo InvoiceOutputInfo { get; set; }

        /// <summary>
        /// 项目来源，如：ocr\einvoice\consume
        /// </summary>
        [JsonPropertyName("item_source")]
        public string ItemSource { get; set; }

        /// <summary>
        /// 项目子类，如：出租车、火车、飞机等
        /// </summary>
        [JsonPropertyName("item_sub_type")]
        public string ItemSubType { get; set; }

        /// <summary>
        /// 项目大类，如：餐饮美食、酒店住宿、差旅出行等
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 增值税发票、定额发票、卷式发票、过路费ocr的扫描数据
        /// </summary>
        [JsonPropertyName("ocr_normal_scan_info")]
        public OcrNormalScanInfo OcrNormalScanInfo { get; set; }

        /// <summary>
        /// 飞机票ocr的数据
        /// </summary>
        [JsonPropertyName("ocr_plane_scan_info")]
        public OcrPlaneScanInfo OcrPlaneScanInfo { get; set; }

        /// <summary>
        /// 出租车发票ocr的数据
        /// </summary>
        [JsonPropertyName("ocr_taxi_scan_info")]
        public OcrTaxiScanInfo OcrTaxiScanInfo { get; set; }

        /// <summary>
        /// 火车票ocr的数据
        /// </summary>
        [JsonPropertyName("ocr_train_scan_info")]
        public OcrTrainScanInfo OcrTrainScanInfo { get; set; }
    }
}
