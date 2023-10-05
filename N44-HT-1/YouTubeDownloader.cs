/*
 * bajarilishiga 20 sekunddan ko'p vaqt ketadigan
 * biror komandani o'ylang, shu bo'yicha service 
 * va methodni yarating ( task,.delay bo'lsa ham bo'laveradi) 
- asosiy main methodda 5 sekund delay bor bo'lgan
cancellation token source yarating va methodga parameter orqali ichidagi tokenni berib yuboring
- dasturni ishlatib method ishlashi 5 sek dan keyin cancel bo'lishini tekshiring
 */


public class YouTubeDownloader
{
    public async ValueTask<bool> Download(CancellationToken cancellationToken)
    {
        Thread.Sleep(10000);
        if(cancellationToken.IsCancellationRequested)
        {
            Console.WriteLine("Your downloading process has been canceled");
            return false;
        }
        Console.WriteLine("Your downloading process has been successfully done");
        return true;
    }
}