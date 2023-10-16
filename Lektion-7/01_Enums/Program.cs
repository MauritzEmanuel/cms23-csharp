using _01_Enums.Enums;
using _01_Enums.Services;


//Man måstre instantiera classen
var weekdayService = new WeekdayService();
weekdayService.Run();

var urlCheckerService = new UrlCheckerService();
await urlCheckerService.Run("https://google.com");