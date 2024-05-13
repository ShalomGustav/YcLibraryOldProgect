using Newtonsoft.Json;

namespace MODELINT.Models
{
    public class YcTranslateRequest
    {
        [JsonProperty("sourceLanguageCode")]
        public string SourceLanguageCode { get; set; }

        [JsonProperty("targetLanguageCode")]
        public string TargetLanguageCode { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("texts")]
        public string[] Texts { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
