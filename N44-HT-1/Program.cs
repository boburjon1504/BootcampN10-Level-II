/*
 * bajarilishiga 20 sekunddan ko'p vaqt ketadigan
 * biror komandani o'ylang, shu bo'yicha service 
 * va methodni yarating ( task,.delay bo'lsa ham bo'laveradi) 
- asosiy main methodda 5 sekund delay bor bo'lgan
cancellation token source yarating va methodga parameter orqali ichidagi tokenni berib yuboring
- dasturni ishlatib method ishlashi 5 sek dan keyin cancel bo'lishini tekshiring
 */


var youTubeDowloader = new YouTubeDownloader();
var cancelation = new CancellationTokenSource(5000);
Console.WriteLine(await youTubeDowloader.Download(cancelation.Token));