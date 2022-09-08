namespace WebAppDETAug2022.Models
{
    public interface IHelo
    {
        string SayHello(string name);

    }



    public class Helo1 : IHelo
    {
        public string SayHello(string name)
        {
            return $"Hello {name}, Welcome to ASP.net Core";
        }
    }



    public class Helo2 : IHelo
    {
        public string SayHello(string name)
        {
            return $"Hello,Hai {name}, Howz the day!!";



        }
    }
}

