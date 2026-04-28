using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class CalendarPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("platformId")]
        public int? PlatformId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("baseCalendarUid")]
        public Guid? BaseCalendarUid { get; set; }

        [JsonProperty("workHoursPerDay")]
        public double? WorkHoursPerDay { get; set; }

        [JsonProperty("days")]
        public List<CalendarDayPayloadDto> Days { get; set; } = new List<CalendarDayPayloadDto>();
    }

    public class CalendarDayPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("isDefaultWeek")]
        public bool IsDefaultWeek { get; set; }

        [JsonProperty("fromDate")]
        public DateTime? FromDate { get; set; }

        [JsonProperty("toDate")]
        public DateTime? ToDate { get; set; }

        [JsonProperty("exceptionDate")]
        public DateTime? ExceptionDate { get; set; }

        [JsonProperty("dayOfWeek")]
        public int? DayOfWeek { get; set; }

        [JsonProperty("isWorkingDay")]
        public bool IsWorkingDay { get; set; }

        [JsonProperty("workingMinutes")]
        public int? WorkingMinutes { get; set; }

        [JsonProperty("shifts")]
        public List<CalendarShiftPayloadDto> Shifts { get; set; } = new List<CalendarShiftPayloadDto>();
    }

    public class CalendarShiftPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("startMinutes")]
        public int StartMinutes { get; set; }

        [JsonProperty("finishMinutes")]
        public int FinishMinutes { get; set; }
    }
}
