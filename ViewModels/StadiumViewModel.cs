using System;

namespace FootballStarz.ViewModels
{
    public class StadiumViewModel
    {
        public int StadiumId { get; set; }
        public string? StadiumName { get; set; }

        public string? Location { get; set; }
        public DateTime BuildDate { get; set; }
        public String? StadiumImage { get; set; }
        public int? ClubId { get; set; }
        public String? ClubName { get; set; }
    }
}
