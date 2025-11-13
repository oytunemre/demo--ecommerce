




[ApiController]
[Route("[controller]")]
public class userAccountController : ControllerBase
{
    // Kullanıcıların kayıt ve giriş işlemlerini yöneten metotlar burada yer alacak.

    userAccountModelDto userDto = new userAccountModelDto();



    public void RegisterUser(userAccountModelDto userDto)
    {
        string username = userDto.username;
        string name = userDto.Name;
        string surname = userDto.Surname;
        string email = userDto.Email;
        string password = userDto.Password;
    }

    public void LoginUser(string username, string password)
    {
        if (username == userDto.username && password == userDto.Password)
        {
            // Giriş başarıllı
            Console.WriteLine("Giriş başarılı!");
        }
        else
        {
            // Giriş başarısız
            Console.WriteLine("Giriş başarısız. Kullanıcı adı veya şifre yanlış.");
        }
    }



}