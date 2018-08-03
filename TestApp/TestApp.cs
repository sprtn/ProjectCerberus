using ToolLibrary.FileHandlers.Logger;
using ToolLibrary.FileHandlers.Logger.Models;

namespace TestApp
{
    internal class TestApp
    {
        public TestApp()
        {
            JsonLogger logger = new JsonLogger();

            logger.LogError("Test error 1");
            logger.LogDebug("Test debug 1");

            logger.LogError(new LogObject("test 2"));
            logger.LogDebug(new LogObject("test debug 2"));

            logger.LogError();
            logger.LogDebug();
        }
    }
}