namespace NotificationSender.WithDI;
public class FileLogger:IAppLogger
{
   public void Log(string message)
    {
        //var directory = new FileInfo("log.txt").Directory;
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}