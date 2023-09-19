using N39_HT_2.Service;

var accountService = new AccountService();
try
{
    accountService.Register("email@gmail.com", "1234");
    accountService.Register("email@gmail.com", "1234");
    accountService.Register("email@gmail.com", "1234");
    accountService.Register("email@gmail.com", "1234");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}