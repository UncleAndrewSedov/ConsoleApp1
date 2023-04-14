using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.GettingUpdates;

internal class Programm
{
    static public string token = "5867230720:AAHVoP-JiEvhV4pzrDN2mWxFLS9o2ow7cFU";
        static public BotClient api = new BotClient(token);
    private static void Main(string[] args)
    {
        var updates = api.GetUpdates();
        while (true)
        {
            if(updates.Any())
            {
                foreach (var item in updates)
                {
                    if (item.Message.Text.ToLower() == "/start")
                    {
                        api.SendMessage(item.Message.Chat.Id, ".\r\n░░░░▓█───────▄▄▀▀▀▄─────\r\n░░░░▒░█────▄█▒░░▄░█─────\r\n░░░░░░░▀▄─▄▀▒▀▀▀▄▄▀─────\r\n░░░░░░░░░█▒░░░░▄▀───────\r\n▒▒▒░░░░▄▀▒░░░░▄▀──────── \r\n▓▓▓▓▒░█▒░░░░░█▄───────── \r\n█████▀▒░░░░░█░▀▄──────── \r\n█████▒▒░░░▒█░░░▀▄─────── \r\n███▓▓▒▒▒▀▀▀█▄░░░░█────── \r\n▓██▓▒▒▒▒▒▒▒▒▒█░░░░█───── \r\n▓▓█▓▒▒▒▒▒▒▓▒▒█░░░░░█──── \r\n░▒▒▀▀▄▄▄▄█▄▄▀░░░░░░░█───");
                    }
                }
                var offset = updates.Last().UpdateId + 1;
                updates = api.GetUpdates(offset);
            }
            else
            {
                updates = api.GetUpdates();
            }
        }
    }
}

