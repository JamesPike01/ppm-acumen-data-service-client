using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Sparse map of UDF slot values for an entity. Only populated slots are included.
    /// Slot names correspond to USER_FIELD_VALUE columns: text1-text20, number1-number20, date1-date20.
    /// </summary>
    public class UserFieldValuesPayloadDto
    {
        [JsonProperty("text1")] public string? Text1 { get; set; }
        [JsonProperty("text2")] public string? Text2 { get; set; }
        [JsonProperty("text3")] public string? Text3 { get; set; }
        [JsonProperty("text4")] public string? Text4 { get; set; }
        [JsonProperty("text5")] public string? Text5 { get; set; }
        [JsonProperty("text6")] public string? Text6 { get; set; }
        [JsonProperty("text7")] public string? Text7 { get; set; }
        [JsonProperty("text8")] public string? Text8 { get; set; }
        [JsonProperty("text9")] public string? Text9 { get; set; }
        [JsonProperty("text10")] public string? Text10 { get; set; }
        [JsonProperty("text11")] public string? Text11 { get; set; }
        [JsonProperty("text12")] public string? Text12 { get; set; }
        [JsonProperty("text13")] public string? Text13 { get; set; }
        [JsonProperty("text14")] public string? Text14 { get; set; }
        [JsonProperty("text15")] public string? Text15 { get; set; }
        [JsonProperty("text16")] public string? Text16 { get; set; }
        [JsonProperty("text17")] public string? Text17 { get; set; }
        [JsonProperty("text18")] public string? Text18 { get; set; }
        [JsonProperty("text19")] public string? Text19 { get; set; }
        [JsonProperty("text20")] public string? Text20 { get; set; }

        [JsonProperty("number1")] public double? Number1 { get; set; }
        [JsonProperty("number2")] public double? Number2 { get; set; }
        [JsonProperty("number3")] public double? Number3 { get; set; }
        [JsonProperty("number4")] public double? Number4 { get; set; }
        [JsonProperty("number5")] public double? Number5 { get; set; }
        [JsonProperty("number6")] public double? Number6 { get; set; }
        [JsonProperty("number7")] public double? Number7 { get; set; }
        [JsonProperty("number8")] public double? Number8 { get; set; }
        [JsonProperty("number9")] public double? Number9 { get; set; }
        [JsonProperty("number10")] public double? Number10 { get; set; }
        [JsonProperty("number11")] public double? Number11 { get; set; }
        [JsonProperty("number12")] public double? Number12 { get; set; }
        [JsonProperty("number13")] public double? Number13 { get; set; }
        [JsonProperty("number14")] public double? Number14 { get; set; }
        [JsonProperty("number15")] public double? Number15 { get; set; }
        [JsonProperty("number16")] public double? Number16 { get; set; }
        [JsonProperty("number17")] public double? Number17 { get; set; }
        [JsonProperty("number18")] public double? Number18 { get; set; }
        [JsonProperty("number19")] public double? Number19 { get; set; }
        [JsonProperty("number20")] public double? Number20 { get; set; }

        [JsonProperty("date1")] public DateTime? Date1 { get; set; }
        [JsonProperty("date2")] public DateTime? Date2 { get; set; }
        [JsonProperty("date3")] public DateTime? Date3 { get; set; }
        [JsonProperty("date4")] public DateTime? Date4 { get; set; }
        [JsonProperty("date5")] public DateTime? Date5 { get; set; }
        [JsonProperty("date6")] public DateTime? Date6 { get; set; }
        [JsonProperty("date7")] public DateTime? Date7 { get; set; }
        [JsonProperty("date8")] public DateTime? Date8 { get; set; }
        [JsonProperty("date9")] public DateTime? Date9 { get; set; }
        [JsonProperty("date10")] public DateTime? Date10 { get; set; }
        [JsonProperty("date11")] public DateTime? Date11 { get; set; }
        [JsonProperty("date12")] public DateTime? Date12 { get; set; }
        [JsonProperty("date13")] public DateTime? Date13 { get; set; }
        [JsonProperty("date14")] public DateTime? Date14 { get; set; }
        [JsonProperty("date15")] public DateTime? Date15 { get; set; }
        [JsonProperty("date16")] public DateTime? Date16 { get; set; }
        [JsonProperty("date17")] public DateTime? Date17 { get; set; }
        [JsonProperty("date18")] public DateTime? Date18 { get; set; }
        [JsonProperty("date19")] public DateTime? Date19 { get; set; }
        [JsonProperty("date20")] public DateTime? Date20 { get; set; }
    }
}
