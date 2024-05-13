using Newtonsoft.Json;

namespace MODELINT.Models
{
    public class YcTranslateResponce
    {
        [JsonProperty("translations")]
        public YcTranslateInnerResponce[] Translations { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }
    }

    public class YcTranslateInnerResponce
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
