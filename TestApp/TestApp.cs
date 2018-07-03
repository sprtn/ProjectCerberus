namespace TestApp
{
    internal class TestApp
    {
        public TestApp()
        {
            ToolLibrary.Logger.Logger.ErrorLog("test");
            ToolLibrary.Logger.Logger.DebugLog("debugtest");
            ToolLibrary.Logger.Logger.SetLogfolder("testFolder");
            ToolLibrary.Logger.Logger.ErrorLog("test2");
            ToolLibrary.Logger.Logger.DebugLog("debugtest2");
        }
    }
}