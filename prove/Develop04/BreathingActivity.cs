public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) {
        
    }

    public void BreatheInAndOut(int duration) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime) {
            Console.Write("Breathe in... ");
            for (int i = 5; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\n\nNow breathe out... ");
            for (int i = 5; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("\n");
        } 
    }
}