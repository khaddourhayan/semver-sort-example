namespace CoreLibCaller
{
    public class Caller
    {
        public static void Run()
        {
            try
            {
                CoreLib.CallService.Run();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in CoreLibCaller", ex);
            }

        }
    }
}
