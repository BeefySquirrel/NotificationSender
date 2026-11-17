namespace NotificationSender.WithoutDI;
public class FileLogger
{
   public void log (string message)
    {
        //var directory = new FileInfo("log.txt").Directory;
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}